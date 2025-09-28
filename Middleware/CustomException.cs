using System;

namespace MiddlewareLayer;
public class CustomException(string message) : Exception(message)
{
    // Optional: Add a method to get all exception messages in the chain
    public string GetAllMessages()
    {
        var messages = new List<string>();
        var currentException = this as Exception;
        
        while (currentException != null)
        {
            if (!string.IsNullOrWhiteSpace(currentException.Message))
            {
                messages.Add(currentException.Message);
            }
            currentException = currentException.InnerException;
        }
        
        return string.Join(" -> ", messages);
    }
}
