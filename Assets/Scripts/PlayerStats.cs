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
    private static int maxJumps = 0;
    public static int MaxJumps{
        get {
            return maxJumps;
        } set {
            maxJumps = value;
        }
    }
}