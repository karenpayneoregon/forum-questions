Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.Pkcs

Module Module1

	Sub Main()
		Dim args() As String = System.Environment.GetCommandLineArgs()

		Dim phCertStore As IntPtr = IntPtr.Zero
		Dim phMsg As IntPtr = IntPtr.Zero
		Dim ppvContext As IntPtr = IntPtr.Zero
		Dim pdwMsgAndCertEncodingType As Integer = 0
		Dim pdwContentType As Integer = 0
		Dim pdwFormatType As Integer = 0

		If Not CryptQueryObject(Wincrypt.CERT_QUERY_OBJECT_FILE, args(0), Wincrypt.CERT_QUERY_CONTENT_FLAG_ALL, Wincrypt.CERT_QUERY_FORMAT_FLAG_ALL, 0, pdwMsgAndCertEncodingType, pdwContentType, pdwFormatType, phCertStore, phMsg, ppvContext) Then
			Console.WriteLine((New Win32Exception(Marshal.GetLastWin32Error())).Message)
			Return
		End If
		Dim pcbData As Integer = 0
		If Not CryptMsgGetParam(phMsg, Wincrypt.CMSG_ENCODED_MESSAGE, 0, Nothing, pcbData) Then
			Console.WriteLine((New Win32Exception(Marshal.GetLastWin32Error())).Message)
			Return
		End If
		Dim pvData(pcbData - 1) As Byte
		CryptMsgGetParam(phMsg, Wincrypt.CMSG_ENCODED_MESSAGE, 0, pvData, pcbData)
		Dim signedCms As New SignedCms()
		signedCms.Decode(pvData)
		Try
			signedCms.CheckSignature(False)
			Console.WriteLine("Signature check passed")
		Catch e As Exception
			Console.WriteLine(e.Message)
		Finally
			CryptMsgClose(phMsg)
			CertCloseStore(phCertStore, 0)
		End Try

	End Sub

End Module
Friend Module Wincrypt
	' source type
	Public Const CERT_QUERY_OBJECT_FILE As Integer = 1
	' object type
	Private Const CERT_QUERY_CONTENT_CERT As Integer = 1
	Private Const CERT_QUERY_CONTENT_CTL As Integer = 2
	Private Const CERT_QUERY_CONTENT_CRL As Integer = 3
	Private Const CERT_QUERY_CONTENT_SERIALIZED_STORE As Integer = 4
	Private Const CERT_QUERY_CONTENT_SERIALIZED_CERT As Integer = 5
	Private Const CERT_QUERY_CONTENT_SERIALIZED_CTL As Integer = 6
	Private Const CERT_QUERY_CONTENT_SERIALIZED_CRL As Integer = 7
	Private Const CERT_QUERY_CONTENT_PKCS7_SIGNED As Integer = 8
	Private Const CERT_QUERY_CONTENT_PKCS7_UNSIGNED As Integer = 9
	Private Const CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED As Integer = 10
	Private Const CERT_QUERY_CONTENT_PKCS10 As Integer = 11
	Private Const CERT_QUERY_CONTENT_PFX As Integer = 12
	Private Const CERT_QUERY_CONTENT_CERT_PAIR As Integer = 13

	Private Const CERT_QUERY_CONTENT_FLAG_CERT As Integer = (1 << CERT_QUERY_CONTENT_CERT)
	Private Const CERT_QUERY_CONTENT_FLAG_CTL As Integer = (1 << CERT_QUERY_CONTENT_CTL)
	Private Const CERT_QUERY_CONTENT_FLAG_CRL As Integer = (1 << CERT_QUERY_CONTENT_CRL)
	Private Const CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE As Integer = (1 << CERT_QUERY_CONTENT_SERIALIZED_STORE)
	Private Const CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT As Integer = (1 << CERT_QUERY_CONTENT_SERIALIZED_CERT)
	Private Const CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL As Integer = (1 << CERT_QUERY_CONTENT_SERIALIZED_CTL)
	Private Const CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL As Integer = (1 << CERT_QUERY_CONTENT_SERIALIZED_CRL)
	Private Const CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED As Integer = (1 << CERT_QUERY_CONTENT_PKCS7_SIGNED)
	Private Const CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED As Integer = (1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED)
	Private Const CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED As Integer = (1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED)
	Private Const CERT_QUERY_CONTENT_FLAG_PKCS10 As Integer = (1 << CERT_QUERY_CONTENT_PKCS10)
	Private Const CERT_QUERY_CONTENT_FLAG_PFX As Integer = (1 << CERT_QUERY_CONTENT_PFX)
	Private Const CERT_QUERY_CONTENT_FLAG_CERT_PAIR As Integer = (1 << CERT_QUERY_CONTENT_CERT_PAIR)
	Public Const CERT_QUERY_CONTENT_FLAG_ALL As Integer =
		CERT_QUERY_CONTENT_FLAG_CERT Or
		CERT_QUERY_CONTENT_FLAG_CTL Or
		CERT_QUERY_CONTENT_FLAG_CRL Or
		CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE Or
		CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT Or
		CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL Or
		CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL Or
		CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED Or
		CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED Or
		CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED Or
		CERT_QUERY_CONTENT_FLAG_PKCS10 Or
		CERT_QUERY_CONTENT_FLAG_PFX Or
		CERT_QUERY_CONTENT_FLAG_CERT_PAIR

	' format type
	Private Const CERT_QUERY_FORMAT_BINARY As Integer = 1
	Private Const CERT_QUERY_FORMAT_BASE64_ENCODED As Integer = 2
	Private Const CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED As Integer = 3
	Private Const CERT_QUERY_FORMAT_FLAG_BINARY As Integer = 1 << CERT_QUERY_FORMAT_BINARY
	Private Const CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED As Integer = 1 << CERT_QUERY_FORMAT_BASE64_ENCODED
	Private Const CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED As Integer = 1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED
	Public Const CERT_QUERY_FORMAT_FLAG_ALL As Integer =
		CERT_QUERY_FORMAT_FLAG_BINARY Or CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED Or CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED

	Public Const CMSG_ENCODED_MESSAGE As Integer = 29

End Module
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

