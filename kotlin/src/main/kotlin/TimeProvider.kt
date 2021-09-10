import java.time.LocalDateTime

class TimeProvider {
    fun currentTime(): LocalDateTime {
        return LocalDateTime.now()
    }
}