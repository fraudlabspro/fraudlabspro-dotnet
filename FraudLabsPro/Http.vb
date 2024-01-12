Imports System.Net
Imports System.Text

Namespace FraudLabsPro
    Public Class Http
        Public Function GetMethod(url As String) As String
            Dim request As HttpWebRequest = WebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            If response.StatusCode = HttpStatusCode.OK Then
                Dim reader As New IO.StreamReader(response.GetResponseStream())
                Dim raw As String = reader.ReadToEnd
                Return raw
            Else
                Return ("Failed : HTTP error code :" & response.StatusCode)
            End If
        End Function
        Public Function PostMethod(url As String, post As String) As String
            Dim encode As UTF8Encoding
            Dim postdata As String = post
            Dim postdatabytes As Byte()

            Dim request As HttpWebRequest = WebRequest.Create(url)
            encode = New UTF8Encoding()
            postdatabytes = encode.GetBytes(postdata)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = postdatabytes.Length

            Using stream = request.GetRequestStream
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim response As HttpWebResponse = request.GetResponse()
            If response.StatusCode = HttpStatusCode.OK Then
                Dim reader As New IO.StreamReader(response.GetResponseStream())
                Dim raw As String = reader.ReadToEnd
                Return raw
            Else
                Return ("Failed : HTTP error code :" & response.StatusCode)
            End If
        End Function
    End Class
End Namespace