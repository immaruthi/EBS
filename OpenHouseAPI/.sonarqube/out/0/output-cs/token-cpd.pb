ý
JD:\GitHub\EBS\EBS\OpenHouseAPI\Application.Common.DataModels\ItemMaster.cs
	namespace 	
Application
 
. 
Common 
. 

DataModels '
{ 
public		 

enum		 

ItemMaster		 
{

 
B4102151 
= 
$num 
, 
N4101070 
= 
$num 
, 
N4101130 
= 
$num 
} 
} ¡
MD:\GitHub\EBS\EBS\OpenHouseAPI\Application.Common.DataModels\ItemModelData.cs
	namespace 	
Application
 
. 
Common 
. 

DataModels '
{ 
public		 

class		 
ItemModelData		 
{

 
public 
string 
ItemDescription %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

ItemMaster 
ItemType "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
Double 
	ItemPrice 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} Æ
MD:\GitHub\EBS\EBS\OpenHouseAPI\Application.Common.DataModels\ProductMaster.cs
	namespace 	
Application
 
. 
Common 
. 

DataModels '
{ 
public		 

enum		 
ProductMaster		 
{

 
Homemade 
= 
$num 
, 
Imported 
= 
$num 
, 
Natural 
= 
$num 
, 
Herbal 
= 
$num 
} 
} Ä
PD:\GitHub\EBS\EBS\OpenHouseAPI\Application.Common.DataModels\ProductModelData.cs
	namespace 	
Application
 
. 
Common 
. 

DataModels '
{ 
public		 

class		 
ProductModelData		 !
{

 
public 
ProductMaster 
ProductType (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
List 
< 
ItemModelData !
>! "
ProductItems# /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
} 
} ‚
WD:\GitHub\EBS\EBS\OpenHouseAPI\Application.Common.DataModels\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str 8
)8 9
]9 :
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str $
)$ %
]% &
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str :
): ;
]; <
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 7
)7 8
]8 9
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *