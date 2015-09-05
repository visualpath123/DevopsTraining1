using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOTNet_Test3
{

	// This is a comment and the next line is commented out
     // Console.WriteLine("Hello, World");

    public class Hello
    {
		///<summary>
	///summary description
	///</summary>
	///<remarks>
	///This is a test.
		///</remarks>

		/* This is a multi-line comment
			 and continues until the end
				of comment symbol is reached */

        public string SaySomething(string input)
        {
			/* for multi line comments */

            if (input.Equals("world"))
                return "Hello World";
            else if (input.Equals("city"))
                return "Hello Hyderabad";
            else if (input.Equals("country"))
            {
                if (DateTime.Now.Ticks.ToString().StartsWith("1"))
                    return "Hello USA";
                else
                    return "Hello India";
            }

            else
            {
                return "Hello";
            }
			/* for multi line comments */

        }

		 public int largeNumber(int x,int y,int z) {

			 int big=0;

			  Console.WriteLine("Three integers  are "+x+","+y+","+z);
			  
			  if ( x > y && x > z ){
				  big=x;
				 Console.WriteLine("First number is largest.");
			  }
			  else if ( y > z ){
				  big=y;
				 Console.WriteLine("Second number is largest.");
			  }
			  else {
				  big=z;
				Console.WriteLine("Third number is largest.");
			  }
			  

			  return big;
			 
		  }

		  public void printInputValue(int a, int b){

          Console.WriteLine("a ="+a+", b="+b);

		  }

		  public bool checkEmpty(int a, int b){
			  if(a >0 && b>0){
				return true;
			  }

           return false;
		  }

		        public int subtract(int a, int b)

                   {

                        if(checkEmpty(a,b)) {

							printInputValue(a,b);
							 return a - b;
				        }
						else{
								printInputValue(a,b);
							throw new Exception("error");

						}


						 

                   }

 

                   public int add(int a, int b)

                   {

                             if(checkEmpty(a,b)) {
                             	printInputValue(a,b);
							 return a + b;
							 }else{
								 	printInputValue(a,b);
							throw new Exception("error");

						}

                   }

 

                   public int divide(int a, int b)

                   {
                        if(checkEmpty(a,b)) {
								printInputValue(a,b);
                             return a / b;
						}else{
								printInputValue(a,b);
							throw new Exception("error");

						}

                   }

 

                   public int multiply(int a, int b)

                   {

                            if(checkEmpty(a,b)) {
									printInputValue(a,b);
							 return a * b;
							 }else{
								 	printInputValue(a,b);
							throw new Exception("error");

						}

                   }

				   public bool myFunction(){
                    
					// Branch Segment 1
					  FunctionA();
					  FunctionB();

					  if (checkEmpty(2,4)) {
						// Branch Segment 2
						FunctionB();
						FunctionC();
					  } else {
						// Branch Segment 3
						FunctionD();
					  }
                    return true;

				   }

				   public void FunctionA(){
					   Console.WriteLine("Third number is largest. FunctionC");

				   }

				   public void FunctionB(){
					   Console.WriteLine("Third number is largest. FunctionC");

				   }
				   public void FunctionC(){
					   Console.WriteLine("Third number is largest. FunctionC");

				   }
				   public void FunctionD(){
					   Console.WriteLine("Third number is largest. FunctionD");

				   }



    }
}
