'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.

REM LineNo: 13
REM ExpectedError: BC30638
REM ErrorMessage: Array bounds cannot appear in type specifiers.

Imports System

Module MethodDeclarationA
	Sub A1(ParamArray ByVal args(10) as Integer)			
	End Sub
	Sub Main()
		A1(New Integer(){1,2,3})
	End Sub
End Module
 
