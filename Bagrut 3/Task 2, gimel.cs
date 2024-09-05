public static int Amount(Committee[] arr, Member m) {
    int count = 0;
    foreach (Committee committee in arr) {
        if (committee.Count < 16) {
            int coalitionMembers = committee.Total(true);
            int nonCoalitionMembers = committee.Total(false);
            
            if (m.IsCoal && coalitionMembers + 1 > nonCoalitionMembers) {
                count++;
            } else if (!m.IsCoal && coalitionMembers > nonCoalitionMembers + 1) {
                count++;
            }
        }
    }
    return count;
}
