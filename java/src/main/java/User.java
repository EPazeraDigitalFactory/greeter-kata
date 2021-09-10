import lombok.Getter;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@Getter
public class User {
    private final String firstName;
    private final String lastName;
    private final LocalDate birthdate;
    private final List<WorkItem> workItems;

    public User(String firstName, String lastName, LocalDate birthdate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthdate = birthdate;
        workItems = new ArrayList<WorkItem>();
    }

    public void addWorkItem(WorkItem workItem) {
        workItems.add(workItem);
    }
}

