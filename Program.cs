/*
NOTES:
-Format for C# is Class.Method, can chain methods: Class.method1.method2
-String manipulation: 
- \n for line breaks 
- + for concatenation 
- @"" for verbatim literal
- ($"{variable}") for interpolation
- ($@" " ); for multi lines interpolated/verbatim
-Methods are private by default (internal/etc to open up).
    -signatures: type, name, and arguments option are mandatory.  Other items can be present
    -void MyMethod() -This is the method signature, void (returns type), MyMethod (method name), Arguments go in ()
-Visual Studio Tip, add method call, test(), then use tooltip to auto generate the empty method eg: void test() {}
-Debugging
-Break points: Can be stepped through, visualize variables
-Can drag arrow for steps up/down for inspection
-Switch Statements
-switch(){ case "": break;
-Visual Studio can auto-generate method based on existing code/param (highlight/right click/refactor)
-Arrays int[] inits an array of ints, 0 index based
-Foreach loops (defined number of loops) vs While loops (loop until condition satisfied)
-Do and Do/While loops
-Lists
    -Vs Array, arrays require a size, lists do not
    -Old way: List<string> games = new List<string>();
    -New way: List<string> games = new();
    -Declarative/Global (good way): var games = new List<string>();
-Classes
    -internal class Menu (Access Modifier(internal) private if blank by default)
    -Must instantiate the class, var menu = new GameMenu()
-Enumerations
-Using Linq, query vs method syntax
-Validation
*/

using MathGame1;


DateTime date = DateTime.UtcNow;

string name = Helpers.GetName();

var menu = new GameMenu();
menu.ShowMenu(name, date);


