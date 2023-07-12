using OperatorOverloading;

var p1 = new Point(10, 20);
var p2 = new Point(5, 4);

var pSum = p1 + p2;
pSum.GetPoint();

var pSub = p1 - p2;
pSub.GetPoint();

var pDiv = p1 / p2;
pDiv.GetPoint();

var pMul = p1 * p2;
pMul.GetPoint();

Console.WriteLine(p1>=p2);
Console.WriteLine(p1<=p2);
Console.WriteLine("-------------");

var p3 = new Point(true);
var p4 = new Point(false);

var pAnd = p3 & p4;
pAnd.GetBool();

var pOr = p3 | p4;
pOr.GetBool();


