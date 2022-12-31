/*
Custom Exception Steps:
1- Create a class that derives from System.Exceptionclass.As a convention,end the class name with Exception Suffix.All .Net exceptions end with,exceptions suffix.

2- Provide a public cunstructor,that takes in a string parameter.This cunstructor simply passes the string parameter,to the base exception class cunstructor.

3- Using InnerExceptions,you can also track back the original exception.if you want to provide this capability for your custom exception class,then overload the cunstructor 

4-If you want your Exception class object to work across application domains,then the object must be serializable.To make your exception class serializable mark it with Serializable attribute and provide a cunstructor that invokes the base Exception class cunstructor that takes in SerializationInfo and StreamingContext object as parameters.
*/
using System;
using System.IO;
using System.Runtime.Serialization;
public class CustomExceptionsDemo
{
	public static void Main(string[] args)
	{
		try
		{
		throw new UserAlredyLoggedInException("User is logged in - no duplicate session allowed");
		}
		catch(UserAlredyLoggedInException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
[Serializable]
public class UserAlredyLoggedInException:Exception
{
	public UserAlredyLoggedInException():base()
	{
	}
	
	public UserAlredyLoggedInException(string Message):base(Message)
	{	
	}
	
	public UserAlredyLoggedInException(string Message,Exception innerException):base(Message,innerException)
	{
	}
	public UserAlredyLoggedInException(SerializationInfo info,StreamingContext context)
	:base(info,context)
	{	
	}
}