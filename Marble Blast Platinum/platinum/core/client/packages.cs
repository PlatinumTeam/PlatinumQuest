//-----------------------------------------------------------------------------
// Torque Game Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

//SHAMELESSLY STOLEN FROM TORQUE CONSTRUCTOR 1.0.4

//*****************************************************************************
//*** Support functions to attempt to fix up packages
package PackageFix {

	function isActivePackage(%package) {
		for (%i = 0; %i < $TotalNumberOfPackages; %i++) {
			if ($Package[%i] $= %package) {
				return true;
				break;
			}
		}
		return false;
	}

	function ActivatePackage(%this) {
		if ($TotalNumberOfPackages $= "")
			$TotalNumberOfPackages = 0;
		else {
			// This package name is allready active, so lets not activate it again.
			if (isActivePackage(%this)) {
				//error("ActivatePackage called for a currently active package!");
				return;
			}
		}
		Parent::ActivatePackage(%this);
		$Package[$TotalNumberOfPackages] = %this;
		$TotalNumberOfPackages++;
	}

	function DeactivatePackage(%this) {
		if (!isActivePackage(%this))
			return;

		%count = 0;
		%counter = 0;

		//find the index number of the package to deactivate
		for (%i = 0; %i < $TotalNumberOfPackages; %i++) {
			if ($Package[%i] $= %this)
				%breakpoint = %i;
		}
		for (%j = 0; %j < $TotalNumberOfPackages; %j++) {
			if (%j < %breakpoint) {
				//go ahead and assign temp array, save code
				%tempPackage[%count] = $Package[%j];
				%count++;
			} else if (%j > %breakpoint) {
				%reactivate[%counter] = $Package[%j];
				$Package[%j] = "";
				%counter++;
			}
		}
		//deactivate all the packagess from the last to the current one
		for (%k = (%counter - 1); %k > -1; %k--)
			Parent::DeactivatePackage(%reactivate[%k]);

		//deactivate the package that started all this
		Parent::DeactivatePackage(%this);

		//dont forget this
		$TotalNumberOfPackages = %breakpoint;

		//reactivate all those other packages
		for (%l = 0; %l < %counter; %l++)
			ActivatePackage(%reactivate[%l]);
	}

	function listPackages() {
		echo("Activated Packages:");
		for (%i = 0; %i < $TotalNumberOfPackages; %i++)
			echo($Package[%i]);
	}
};
activatePackage(PackageFix);
