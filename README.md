wellknown.net
=============

This project is used to export the processing methods of spatial data in the NetTopologySuite library to VBA development call.


Exported Method
---------------

* GeoJsonFromWKT - Convert WKT string to GeoJSON string

```VBA
'//VBA call example
Private Declare Function GeoJsonFromWKT Lib "wellknown.net.dll" (ByVal wkt As String) As String

Sub main()

    Dim sjson As String
    sjson = GeoJsonFromWKT("POINT (0 1)")
    sjson = Mid(sjson, 1, Len(sjson) - 1)
    
    Dim jsonobj As Object
    With CreateObject("msscriptcontrol.scriptcontrol")
        .Language = "JavaScript"
        .addcode "var geo=" & sjson
        Set jsonobj = .codeobject
    End With
    
    Debug.Print CallByName(jsonobj.geo, "type", VbGet) 'Point
    Debug.Print CallByName(jsonobj.geo, "coordinates", VbGet) '0,1
    
End Sub
```