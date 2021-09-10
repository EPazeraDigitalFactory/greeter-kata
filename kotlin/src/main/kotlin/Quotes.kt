import java.text.MessageFormat

object Quotes {
    fun GetAll(): List<String> {
        return listOf(
            MessageFormat.format("Intelligence is the ability to adapt to change.{0} --Stephen Hawking", System.lineSeparator()),
            MessageFormat.format("A plan is an example of what could happen, not a prediction of what will happen.{0} --Kent Beck", System.lineSeparator()),
            MessageFormat.format("Code never lies, comments sometimes do.{0} --Ron Jeffries", System.lineSeparator()),
            MessageFormat.format("Any fool can write code that a computer can understand. Good programmers write code that humans can understand.{0} --Ron Jeffries", System.lineSeparator()),
            MessageFormat.format("If you are afraid to change something it is clearly poorly designed.{0} --Ron Jeffries", System.lineSeparator()),
            MessageFormat.format("If you can dream it, you can do it.{0} --Walt Disney", System.lineSeparator()),
            MessageFormat.format("Perfection is not attainable, but if we chase perfection we can catch excellence.{0} --Vince Lombardi", System.lineSeparator())
        )
    }
}