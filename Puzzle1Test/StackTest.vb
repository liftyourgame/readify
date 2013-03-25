Imports System.Text
Imports Puzzle1.Stack(Of Double)

<TestClass()>
Public Class StackTest

    Private _testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return _testContextInstance
        End Get
        Set(ByVal value As TestContext)
            _testContextInstance = value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region

    <TestMethod()>
    Public Sub TestEmptyPop()
        Dim stack As Stack(Of Double) = New Stack(Of Double)(10)

        Try
            stack.Pop()

            Assert.Fail("Should not reach this point")
        Catch ex As Exception

        End Try
    End Sub

    <TestMethod()>
    Public Sub TestPushPop()
        Dim stack As Stack(Of Double) = New Stack(Of Double)(10)

        stack.Push(123.456)
        Dim d As Double = stack.Pop()

        Assert.AreEqual(d, 123.456)
    End Sub

    <TestMethod()>
    Public Sub TestPushTooMany()
        Dim stack As Stack(Of Double) = New Stack(Of Double)(1)

        Try

            stack.Push(123.456)
            stack.Push(89.123)
            Assert.Fail("Should not reach this point")
        Catch ex As Exception
        End Try
    End Sub

End Class
