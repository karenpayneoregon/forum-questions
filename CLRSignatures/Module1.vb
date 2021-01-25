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