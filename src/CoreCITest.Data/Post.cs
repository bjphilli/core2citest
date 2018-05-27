namespace CoreCITest.Data
{
    public class Post
    {
        private Post() { }

        public Post(string text)
        {
            Text = text;
        }

        public long Id { get; set; }

        public string Text { get; set; }
    }
}
