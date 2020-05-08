public static class PlayerStats {
    private static int coin = 0;
    public static int Coin {
        get {
            return coin;
        } set {
            coin = value;
        }
    }

    private static int life = 3;
    public static int Life {
        get {
            return life;
        } set {
            life = value;
        }
    }
}