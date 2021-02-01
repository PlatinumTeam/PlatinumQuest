//-----------------------------------------------------------------------------
// Box Math! Hooray!
//
// Copyright (c) 2015 The Platinum Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//-----------------------------------------------------------------------------

function MatrixMulBox(%matrix, %box, %center) {
	//Calculate center if not given
	if (%center $= "")
		%center = VectorScale(VectorAdd(getWords(%box, 0, 2), getWords(%box, 3, 5)), 0.5);

	//Take every point (+/- x, y, z) and:
	// - Translate it by the center to translate world-space to box-space
	// - Rotate the point by the matrix
	// - Translate it back to world-space
	%a = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 2), %center)), %center);
	%b = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 2), %center)), %center);
	%c = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 2), %center)), %center);
	%d = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 2), %center)), %center);
	%e = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 0) SPC getWord(%box, 1) SPC getWord(%box, 5), %center)), %center);
	%f = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 3) SPC getWord(%box, 1) SPC getWord(%box, 5), %center)), %center);
	%g = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 0) SPC getWord(%box, 4) SPC getWord(%box, 5), %center)), %center);
	%h = VectorAdd(MatrixMulPoint(%matrix, VectorSub(getWord(%box, 3) SPC getWord(%box, 4) SPC getWord(%box, 5), %center)), %center);

	//Create a union box of all points
	%box =                %a SPC %a;
	%box = BoxUnion(%box, %b SPC %b);
	%box = BoxUnion(%box, %c SPC %c);
	%box = BoxUnion(%box, %d SPC %d);
	%box = BoxUnion(%box, %e SPC %e);
	%box = BoxUnion(%box, %f SPC %f);
	%box = BoxUnion(%box, %g SPC %g);
	%box = BoxUnion(%box, %h SPC %h);

	return %box;
}

function BoxMin(%box) {
	return getWords(%box, 0, 2);
}
function BoxMax(%box) {
	return getWords(%box, 3, 5);
}
function BoxMinX(%box) {
	return getWord(%box, 0);
}
function BoxMinY(%box) {
	return getWord(%box, 1);
}
function BoxMinZ(%box) {
	return getWord(%box, 2);
}
function BoxMaxX(%box) {
	return getWord(%box, 3);
}
function BoxMaxY(%box) {
	return getWord(%box, 4);
}
function BoxMaxZ(%box) {
	return getWord(%box, 5);
}
function BoxSizeX(%box) {
	return BoxMaxX(%box) - BoxMinX(%box);
}
function BoxSizeY(%box) {
	return BoxMaxY(%box) - BoxMinY(%box);
}
function BoxSizeZ(%box) {
	return BoxMaxZ(%box) - BoxMinZ(%box);
}
function BoxCenterX(%box) {
	return (BoxMaxX(%box) + BoxMinX(%box)) / 2;
}
function BoxCenterY(%box) {
	return (BoxMaxY(%box) + BoxMinY(%box)) / 2;
}
function BoxCenterZ(%box) {
	return (BoxMaxZ(%box) + BoxMinZ(%box)) / 2;
}
function BoxUnion2(%a, %b) {
	return BoxUnion(%a, %b);
}

function BoxExtend(%box, %length) {
	if (getWordCount(%length) == 1) {
		//Scalar; extend all directions by %length
		return VectorAdd(BoxMin(%box), VectorScale("1 1 1", -%length)) SPC
		       VectorAdd(BoxMax(%box), VectorScale("1 1 1",  %length));
	} else if (getWordCount(%length) == 3) {
		//Vector; extend by adding
		return VectorSub(BoxMin(%box), %length) SPC
		       VectorAdd(BoxMax(%box), %length);
	} else if (getWordCount(%length) == 6) {
		//Box; extend by adding
		return VectorSub(BoxMin(%box), BoxMin(%length)) SPC
		       VectorAdd(BoxMax(%box), BoxMax(%length));
	}
}
