public static class Processor
{
    public static int hourMinuteAngleSum(int hour, int minute) {
        return minuteAngle(minute) + hourAngle(hour);
    }

    public static int minuteAngle(int minute) {
        int minuteAngle = minute * 6;

        return minuteAngle;
    }

    public static int hourAngle(int hour) {
        int hourNumToMinuteNum = hour * 5;

        int hourAngle = hourNumToMinuteNum * 6;

        return hourAngle;
    }
}