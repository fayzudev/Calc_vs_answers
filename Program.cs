// Laboratoriya 1
// 1-variant =>a

// System.Console.Write($"x sonini kiriting: ");
// string xx = System.Console.ReadLine();
// System.Console.Write($"y sonini kiriting: ");
// string yy = System.Console.ReadLine();
// double x = Convert.ToDouble(xx);
// double y = Convert.ToDouble(yy);
//System.Console.WriteLine("-----------------------");
// double a= (2*Math.Cos(x-Math.PI/6))/((1/2)+Math.Pow(Math.Sin(y),2));
// System.Console.WriteLine($"Masalaning javobi {a}");

// =>b

// System.Console.Write("z sonini kiriting: ");
// string zz = System.Console.ReadLine();
// double z = Convert.ToDouble(zz);
//System.Console.WriteLine("-----------------------");
// double b = 1+(Math.Pow(z,2)/(3+Math.Pow(z,2)/5));
// System.Console.WriteLine($"b variantning javobi {b}");

// 2-variant

// System.Console.Write("x ni kiriting: ");
// string xx = System.Console.ReadLine();
// System.Console.Write("y ni kiriting: ");
// string yy = System.Console.ReadLine();
// System.Console.Write("z ni kiriting: ");
// string zz = System.Console.ReadLine();
// double x = Convert.ToDouble(xx);
// double y = Convert.ToDouble(yy);
// double z = Convert.ToDouble(zz);
// System.Console.WriteLine("-----------------------");
// //a 
// double yx = Math.Abs(Math.Pow(x,y/x)-Math.Pow(y/x,1/3));
// System.Console.WriteLine($"a variant javobi: {yx}");
// System.Console.WriteLine("-----------------------");
// //b
// double xy = (y-x)*(y-(z/(y-x)))/(1+Math.Pow((y-x),2));
// System.Console.WriteLine($"b variant javobi: {xy}");

//3-variant
//a

// System.Console.Write("x ni kiriting: ");
// string xx = System.Console.ReadLine();
// System.Console.Write("y ni kiriting: ");
// string yy = System.Console.ReadLine();
// // System.Console.Write("a ni kiriting: ");
// // string aa = System.Console.ReadLine();
// double x=Convert.ToDouble(xx);
// double y = Convert.ToDouble(yy);
// // int a = Convert.ToInt32(aa);
// // int b=a;
// // for (int i=1;i<a;i++)
// // {
// //     b=b*i;
    
// // }
// //=>a
// double s = 1+x+Math.Pow(x,2)/2+Math.Pow(x,3)/(2*3)+Math.Pow(x,4)/(2*3*4);
// double d = x*(Math.Sin(Math.Pow(x,2))+Math.Pow(Math.Cos(y),2));
// System.Console.WriteLine($"a masalaning javobi: {s}");
// System.Console.WriteLine($"b masalaning javobi: {d}");


// //4-variant

// System.Console.Write("a ni kiriting: ");
// string aa = System.Console.ReadLine();
// System.Console.Write("b ni kiriting: ");
// string bb = System.Console.ReadLine();
// System.Console.Write("a ni kiriting: ");
// string tt = System.Console.ReadLine();
// double a = Convert.ToDouble(aa);
// double b = Convert.ToDouble(bb);
// double t = Convert.ToDouble(tt);

// //=>a

// double y = Math.Pow(Math.E,(-(b*t)))*Math.Sin(a*t+b)-Math.Pow(Math.Abs(b*t+a),1/2);
// System.Console.WriteLine($"a masalaning javobi: {y}");

// //=>b

// double s = b*(Math.Sin(a*Math.Pow(t,2)*Math.Cos(2*t)))-1;
// System.Console.WriteLine($"b masalaning javobi: {s}");

//=>b

//5-masala

// System.Console.Write("a ni kiriting: ");
// string aa = System.Console.ReadLine();
// System.Console.Write("b ni kiriting: ");
// string bb = System.Console.ReadLine();
// System.Console.Write("x ni kiriting: ");
// string xx = System.Console.ReadLine();
// double a = Convert.ToDouble(aa);
// double b = Convert.ToDouble(bb);
// double x = Convert.ToDouble(xx);

// // =>a
// double w = Math.Sqrt(Math.Pow(a,2)+b)-(Math.Pow(b,2)*Math.Pow(Math.Sin(x+a),3))/x;
// System.Console.WriteLine($"a masalaning javobi: {w}");
// //=>b
// double y = Math.Pow(Math.Cos(Math.Pow(x,3)),2)-x/Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
// System.Console.WriteLine($"b masalaning javobi: {y}");

//6-masala

System.Console.Write("a ni kiriting: ");
double a = double.Parse(System.Console.ReadLine());
System.Console.Write("b ni kiriting: ");
double b = double.Parse(System.Console.ReadLine());
System.Console.Write("x ni kiriting: ");
double x = double.Parse(System.Console.ReadLine());
 //=>a
 double s = Math.Pow(x,3)*Math.Pow(Math.Tan(Math.Pow(x+b,2)),2)+a/(Math.Sqrt(x+b));
System.Console.WriteLine($"a masalaning javobi: {s}");
 //=>b
 double q = (b*Math.Pow(x,2)-a)/(Math.Pow(Math.E,a*x)-1);
 System.Console.WriteLine($"b masalaning javobi: {q}");



