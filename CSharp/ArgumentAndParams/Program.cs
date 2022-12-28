using ArgumentAndParams;


//// pure oop
//ArgumentClass argu = new ArgumentClass();

//// var
//var argu = new ArgumentClass();

// target-type
ArgumentClass argu = new();

// named argument
argu.Display(4, 5, 6);

argu.Show(10);
argu.Show(11,4);

argu.SumParam(1, 2, 3,4);
