import java.time.LocalDate
import java.util.ArrayList

class User(val firstName: String, val lastName: String, val birthdate: LocalDate) {
    private val workItems: MutableList<WorkItem>
    fun addWorkItem(workItem: WorkItem) {
        workItems.add(workItem)
    }

    init {
        workItems = ArrayList()
    }
}