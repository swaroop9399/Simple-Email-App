namespace SimpleEmailApp.Services.EmailService
{
    internal class Attachment
    {
        private object value;
        private object filename;

        public Attachment(object value, object filename)
        {
            this.value = value;
            this.filename = filename;
        }
    }
}