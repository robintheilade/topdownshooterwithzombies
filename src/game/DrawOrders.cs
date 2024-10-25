namespace game
{
    public enum DrawOrders
    {
        ClearGraphicsDevice = 0,
        BeforeSceneRender = 1_000,
        RenderCharacterTest = 5_000,
        AfterSceneRender = 10_000,
    }
}