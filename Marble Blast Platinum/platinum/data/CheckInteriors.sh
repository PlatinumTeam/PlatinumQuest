#!/bin/bash

# CDs to the current directory of the file
DIR=`echo $0 | sed -E 's/\/[^\/]+$/\//'`
if [ "X$0" != "X$DIR" ]; then
	cd "$DIR"
fi

# Allows \r \n and other crap in filenames
SAVEIFS=$IFS
IFS=$(echo -en "\n\b");

rm -f interiors.txt
touch interiors.txt

echo '--- Scanning Files ---'

declare -a dif
difs=0

# Iterate through all mission files
for i in $(find . -type f \( -iname "*.m?s" -and \! \( -path "*/custom/*" \) \))
do
	file=${i}

	# If the file exists (I hope so)
	if [ -e $file ]
	then
		echo "Scanning $file"

		# Does three things at once:
		#
		# grep "interiorFile" "$file"
		# Searches the mission file for "interiorFile"
		#
		# sed -E 's/+ interiorFile = "([^"]*)";/\1/g'
		# Strips interiorFile = "";
		#
		# sed 's/~\/data\///g'
		# Strips ~/data/
		#

		interiors=$(grep -Ee '(interiorFile|interiorResource)' "$file" | tr '\r' '\n' | sed -E 's/\$usermods @ \"/\"~/g' | sed -E 's/(interiorFile|interiorResource) = \"([^\"]*)";/\2/g' | sed -E 's/(~|platinum|marble)\/data\//.\//g' | sed -E 's/interiors_MBP/interiors_mbp/g' | sed -E 's/^[[:space:]]*//')

		# Store it!
		while read line
		do
			dif+=("$line")
		done < <(printf '%s\n' "$interiors")
	fi
done

echo '--- Sorting and Uniquing ---'

interiors=$(echo "${dif[@]}" | tr ' ' '\n' | grep '\.dif' | sort -u)

printf "%s\n" "$interiors" > interiors.txt

conts=$(cat interiors.txt)
while read dif
do
	if [ ! -f "$dif" ]
	then
		echo "Can't find $dif"
	fi
done < <(printf '%s\n', "$conts")

# Iterate through all interior files
for i in $(find . -type f \( -iname "*.dif" \))
do
   file=${i}

   # If the file exists (I hope so)
   if [ -e $file ]
   then
#      echo "Checking $file"

      # Check if the file is one of the ones we want
      check=$(grep -iEe "$file" interiors.txt)

      # If $check is zero length
      if [ -z "$check" ]
      then
         echo "Unused: $file"
      fi
   fi
done

# Revert state
IFS=$SAVEIFS
