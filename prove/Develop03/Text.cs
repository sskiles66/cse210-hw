public class Text{
    private string _text;

    private List<string> _words = new List<string>();

    private List<string> _texts = new List<string>{
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", 
        "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.", 
        "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you always, even unto the end of the world. Amen.",
        "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.",
        "Look unto me in every thought; doubt not, fear not."
    };

    public string RandText(int index){
        _text = _texts[index];
        return _text;
    }

}