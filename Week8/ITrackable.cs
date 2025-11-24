namespace Week8
{
    public enum DeliveryStatus
    {
        Processing,
        InTransit,
        OutForDelivery,
        Delivered
    }

    public interface ITrackable
    {
        void UpdateStatus(DeliveryStatus newStatus);
        DeliveryStatus GetStatus();
    }
}