namespace Hospital_Management_System_API.CustomMiddlewares
{
    public static class CustomMiddleware
    {
        public static void ConfigureExceptionHandler(this WebApplication application) 
        {
            application.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
