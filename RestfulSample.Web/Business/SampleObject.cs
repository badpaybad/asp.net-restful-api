namespace RestfulSample.Web.Business
{
    public class SampleObject
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class UploadOjbect
    {
        public string ContentBase64 { get; set; }
        public string FullName { get; set; }
    }
}