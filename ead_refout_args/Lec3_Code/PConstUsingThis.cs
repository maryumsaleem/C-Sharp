namespace Dummy
{
    public class Something
    {
        private string myName;
        private int myIndex;
 // Chaining Constructor
 // : Indicating how to call the another constructor on the current class or a base class's constructor prior to the current constructor.
        public Something() : this("default"){}
 
        public Something(string name) : this(name, -1) {}
 
        public Something(string name, int index)
        {
            myName = name;
            myIndex= index;
 
            DoStuff(); 
        }
 
        private void DoStuff()
        {
            // logic
        }
                    
        // rest of class definition    
	}
}