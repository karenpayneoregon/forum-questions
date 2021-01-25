Imports System.Runtime.InteropServices

Friend Module Crypt32

    <DllImport("crypt32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function CryptQueryObject(
                                     dwObjectType As Integer,
                                     <MarshalAs(UnmanagedType.LPWStr)>
                                     pvObject As String,
                                     dwExpectedContentTypeFlags As Integer,
                                     dwExpectedFormatTypeFlags As Integer,
                                     dwFlags As Integer,
                                     ByRef pdwMsgAndCertEncodingType As Integer,
                                     ByRef pdwContentType As Integer,
                                     ByRef pdwFormatType As Integer,
                                     ByRef phCertStore As IntPtr,
                                     ByRef phMsg As IntPtr,
                                     ByRef ppvContext As IntPtr) As Boolean
    End Function
    <DllImport("crypt32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function CryptMsgGetParam(
                                     hCryptMsg As IntPtr,
                                     dwParamType As Integer,
                                     dwIndex As Integer, pvData() As Byte,
                                     ByRef pcbData As Integer) As Boolean
    End Function
    <DllImport("crypt32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function CryptMsgClose(ByVal hCryptMsg As IntPtr) As Boolean
    End Function
    <DllImport("crypt32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function CertCloseStore(ByVal hCertStore As IntPtr, ByVal dwFlags As Integer) As Boolean
    End Function
End Module