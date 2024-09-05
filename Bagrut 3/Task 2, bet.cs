public int Total(bool belong) {
    int total = 0;
    for (int i = 0; i < Count; i++) {
        if (Members[i].IsCoal == belong) {
            total++;
        }
    }
    return total;
}
