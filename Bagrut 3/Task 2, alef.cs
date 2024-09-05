public class Member {
    public string Name { get; set; }
    public bool IsCoal { get; set; }
}

public class Committee {
    public string Name { get; set; }
    public Member[] Members { get; set; }
    public int Count { get; set; }
}
