/* File : lib_csharp.i*/
%module(directors="1") native_cs
%{

#include "lib.h"

%}

/* turn on director wrapping */
%include "stl.i"
%include "arrays_csharp.i"

%template(IntVector) std::vector<int>;

%include "lib.h"
