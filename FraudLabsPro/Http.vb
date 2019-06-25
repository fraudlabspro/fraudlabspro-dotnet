Imports System.Net
Imports System.Text

Namespace FraudLabsPro
    Public Class Http
        Public Function GetMethod(ByVal url As String) As String
            Try
                Dim request As HttpWebRequest = Nothing
                Dim response As Net.HttpWebResponse = Nothing
                Dim stream As IO.Stream = Nothing
                request = Net.WebRequest.Create(url)
                request.Method = "GET"
                response = request.GetResponse()
                If response.StatusCode = HttpStatusCode.OK Then
                    Dim reader As System.IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
                    Dim raw As String = reader.ReadToEnd
                    Return raw
                Else
                    Return ("Failed : HTTP error code :" & response.StatusCode)
                End If
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function
        Public Function PostMethod(ByVal url As String, post As String) As String
            Try
                Dim request As HttpWebRequest = Nothing
                Dim response As HttpWebResponse = Nothing
                Dim encode As UTF8Encoding
                Dim postdata As String = post
                Dim postdatabytes As Byte()

                request = HttpWebRequest.Create(url)
                encode = New System.Text.UTF8Encoding()
                postdatabytes = encode.GetBytes(postdata)
                request.Method = "POST"
                request.ContentType = "application/x-www-form-urlencoded"
                request.ContentLength = postdatabytes.Length

                Using stream = request.GetRequestStream
                    stream.Write(postdatabytes, 0, postdatabytes.Length)
                End Using
                response = request.GetResponse()
                If response.StatusCode = HttpStatusCode.OK Then
                    Dim reader As System.IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
                    Dim raw As String = reader.ReadToEnd
                    Return raw
                Else
                    Return ("Failed : HTTP error code :" & response.StatusCode)
                End If
            Catch ex As Exception
                Throw New Exception
            End Try
        End Function
    End Class
End Namespace