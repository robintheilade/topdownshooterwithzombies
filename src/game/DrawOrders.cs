namespace game
{
    public enum DrawOrders
    {
        CLEAR_GRAPHICS_DEVICE = 0,
        BEFORE_SCENE_RENDER = 1_000,
        RENDER_CHARACTER_TEST = 5_000,
        AFTER_SCENE_RENDER = 10_000,
    }
}