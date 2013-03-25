Imports System.Text
Imports Puzzle3

<TestClass()>
Public Class ReverseWordsTest

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
            testContextInstance = Value
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
    Public Sub TestReverse3Words()
        Assert.AreEqual(ReverseWords.Reverse("Cat and dog"), "taC dna god")
    End Sub

    <TestMethod()>
    Public Sub TestReverseEmptyString()
        Assert.AreEqual(ReverseWords.Reverse(""), "")
    End Sub

    <TestMethod()>
    Public Sub TestReverse1Word()
        Assert.AreEqual(ReverseWords.Reverse("Cat"), "taC")
    End Sub
End Class
