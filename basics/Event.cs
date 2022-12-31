using System.Text;
using System.Threading.Tasks;
namespace testEvent
{
	delegate void MyEventHandler();
	
	class Button
	{
		//
		
			//An event always belongs to some class
			public event MyEventHandler click; //click is the name of event handler
			
			public void OnClick()
			{
				click();
			}
			
			class HandlerClass
			{
				public void EventHandlerFunction()
				{
					Console.WriteLine("Event Handler get Called");
				}
			}
			
			class Program
			{
				static void Main(string[] args)
				{
					Button b=new Button();
					
					//register the event handler
					b.click=delegate;//anonymous method
					{
						Console.WriteLine("Event occured");
					}
					
					//register the event handler
					b.click +=Console.WriteLine("Event Occured and we are in lmbda handler");
					
					HandlerClass O=new HandlerClass();
					//register the event handler
					b.click +=o.EventHandlerFunction;
					
					//firing the event
					b.OnClick();
					
					
					System.Console.ReadKey();
				}
				
			}
		
	}
}