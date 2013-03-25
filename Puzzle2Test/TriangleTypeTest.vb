Imports System.Text
Imports Puzzle2

<TestClass()>
Public Class TriangleTypeTest

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
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
    Public Sub TestEquilateral()
        Assert.AreEqual(TriangleType.GetType(1, 1, 1), "EQUILATERAL")
    End Sub

    <TestMethod()>
    Public Sub TestIsosceles()
        Assert.AreEqual(TriangleType.GetType(1, 1, 2), "ISOSCELES")
    End Sub

    <TestMethod()>
    Public Sub TestSacalene()
        Assert.AreEqual(TriangleType.GetType(1, 2, 3), "SCALENE")
    End Sub

    <TestMethod()>
    Public Sub TestError()
        Assert.AreEqual(TriangleType.GetType(1, 0, 3), "ERROR")
    End Sub

End Class
