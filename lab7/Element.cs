namespace lab7
{
    internal class Element
    {
        public Element previous;
        public Element next;
        public int value;

        public void SetNext(Element next)
        {
            next.previous = this;
            this.next = next;
        }

        public void SetPrevious(Element previous)
        {
            this.previous = previous;
            previous.next = this;
        }

        public void DeleteNext()
        {
            Element nextNextElement = this.next.next;
            this.next = nextNextElement;
            nextNextElement.previous = this;
        }


    }
}
