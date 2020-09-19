Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Module RichTextExtensions
    <Extension()>
    Sub ClearAllFormatting(ByVal te As RichTextBox, ByVal font As Font)
        Dim fmt As CHARFORMAT2 = New CHARFORMAT2()
        fmt.cbSize = Marshal.SizeOf(fmt)
        fmt.dwMask = CFM_ALL2
        fmt.dwEffects = CFE_AUTOCOLOR Or CFE_AUTOBACKCOLOR
        fmt.szFaceName = font.FontFamily.Name
        Dim size As Double = font.Size

        size /= 72


        size *= 1440.0


        fmt.yHeight = CInt(size)
        fmt.yOffset = 0
        fmt.crTextColor = 0
        fmt.bCharSet = 1
        fmt.bPitchAndFamily = 0
        fmt.wWeight = 400
        fmt.sSpacing = 0
        fmt.crBackColor = 0
        fmt.dwMask = fmt.dwMask And Not CFM_LCID
        fmt.dwReserved = 0
        fmt.sStyle = 0
        fmt.wKerning = 0
        fmt.bUnderlineType = 0
        fmt.bAnimation = 0
        fmt.bRevAuthor = 0
        fmt.bReserved1 = 0
        SendMessage(te.Handle, EM_SETCHARFORMAT, SCF_ALL, fmt)
    End Sub

    Private Const WM_USER As UInt32 = &H400
    Private Const EM_GETCHARFORMAT As UInt32 = (WM_USER + 58)
    Private Const EM_SETCHARFORMAT As UInt32 = (WM_USER + 68)
    Private Const SCF_ALL As UInt32 = &H4
    Private Const SCF_SELECTION As UInt32 = &H1
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As UInt32, ByRef lParam As CHARFORMAT2) As IntPtr

    End Function

    <StructLayout(LayoutKind.Sequential, Pack:=4, CharSet:=CharSet.Auto)>
    Structure CHARFORMAT2
        Public cbSize As Integer
        Public dwMask As UInteger
        Public dwEffects As UInteger
        Public yHeight As Integer
        Public yOffset As Integer
        Public crTextColor As Integer
        Public bCharSet As Byte
        Public bPitchAndFamily As Byte
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public szFaceName As String
        Public wWeight As Short
        Public sSpacing As Short
        Public crBackColor As Integer
        Public lcid As Integer
        Public dwReserved As Integer
        Public sStyle As Short
        Public wKerning As Short
        Public bUnderlineType As Byte
        Public bAnimation As Byte
        Public bRevAuthor As Byte
        Public bReserved1 As Byte
    End Structure

    Const CFE_BOLD As UInt32 = &H1
    Const CFE_ITALIC As UInt32 = &H2
    Const CFE_UNDERLINE As UInt32 = &H4
    Const CFE_STRIKEOUT As UInt32 = &H8
    Const CFE_PROTECTED As UInt32 = &H10
    Const CFE_LINK As UInt32 = &H20
    Const CFE_AUTOCOLOR As UInt32 = &H40000000
    Const CFE_SMALLCAPS As UInt32 = CFM_SMALLCAPS
    Const CFE_ALLCAPS As UInt32 = CFM_ALLCAPS
    Const CFE_HIDDEN As UInt32 = CFM_HIDDEN
    Const CFE_OUTLINE As UInt32 = CFM_OUTLINE
    Const CFE_SHADOW As UInt32 = CFM_SHADOW
    Const CFE_EMBOSS As UInt32 = CFM_EMBOSS
    Const CFE_IMPRINT As UInt32 = CFM_IMPRINT
    Const CFE_DISABLED As UInt32 = CFM_DISABLED
    Const CFE_REVISED As UInt32 = CFM_REVISED
    Const CFE_AUTOBACKCOLOR As UInt32 = CFM_BACKCOLOR
    Const CFM_BOLD As UInt32 = &H1
    Const CFM_ITALIC As UInt32 = &H2
    Const CFM_UNDERLINE As UInt32 = &H4
    Const CFM_STRIKEOUT As UInt32 = &H8
    Const CFM_PROTECTED As UInt32 = &H10
    Const CFM_LINK As UInt32 = &H20
    Const CFM_SIZE As UInteger = &H80000000L
    Const CFM_COLOR As UInt32 = &H40000000
    Const CFM_FACE As UInt32 = &H20000000
    Const CFM_OFFSET As UInt32 = &H10000000
    Const CFM_CHARSET As UInt32 = &H8000000
    Const CFM_SMALLCAPS As UInt32 = &H40
    Const CFM_ALLCAPS As UInt32 = &H80
    Const CFM_HIDDEN As UInt32 = &H100
    Const CFM_OUTLINE As UInt32 = &H200
    Const CFM_SHADOW As UInt32 = &H400
    Const CFM_EMBOSS As UInt32 = &H800
    Const CFM_IMPRINT As UInt32 = &H1000
    Const CFM_DISABLED As UInt32 = &H2000
    Const CFM_REVISED As UInt32 = &H4000
    Const CFM_BACKCOLOR As UInt32 = &H4000000
    Const CFM_LCID As UInt32 = &H2000000
    Const CFM_UNDERLINETYPE As UInt32 = &H800000
    Const CFM_WEIGHT As UInt32 = &H400000
    Const CFM_SPACING As UInt32 = &H200000
    Const CFM_KERNING As UInt32 = &H100000
    Const CFM_STYLE As UInt32 = &H80000
    Const CFM_ANIMATION As UInt32 = &H40000
    Const CFM_REVAUTHOR As UInt32 = &H8000
    Const CFE_SUBSCRIPT As UInt32 = &H10000
    Const CFE_SUPERSCRIPT As UInt32 = &H20000
    Const CFM_SUBSCRIPT As UInt32 = (CFE_SUBSCRIPT Or CFE_SUPERSCRIPT)
    Const CFM_SUPERSCRIPT As UInt32 = CFM_SUBSCRIPT
    Const CFM_EFFECTS As UInt32 = (CFM_BOLD Or CFM_ITALIC Or CFM_UNDERLINE Or CFM_COLOR Or CFM_STRIKEOUT Or CFE_PROTECTED Or CFM_LINK)
    Const CFM_ALL As UInt32 = (CFM_EFFECTS Or CFM_SIZE Or CFM_FACE Or CFM_OFFSET Or CFM_CHARSET)
    Const CFM_EFFECTS2 As UInt32 = (CFM_EFFECTS Or CFM_DISABLED Or CFM_SMALLCAPS Or CFM_ALLCAPS Or CFM_HIDDEN Or CFM_OUTLINE Or CFM_SHADOW Or CFM_EMBOSS Or CFM_IMPRINT Or CFM_DISABLED Or CFM_REVISED Or CFM_SUBSCRIPT Or CFM_SUPERSCRIPT Or CFM_BACKCOLOR)
    Const CFM_ALL2 As UInt32 = (CFM_ALL Or CFM_EFFECTS2 Or CFM_BACKCOLOR Or CFM_LCID Or CFM_UNDERLINETYPE Or CFM_WEIGHT Or CFM_REVAUTHOR Or CFM_SPACING Or CFM_KERNING Or CFM_STYLE Or CFM_ANIMATION)
End Module
