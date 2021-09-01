import org.junit.Before;
import org.junit.Test;
import org.mockito.MockitoAnnotations;


import static org.junit.Assert.*;

public class GreeterTest {

   // @Mock
    // private TimeProvider timeProviderMock;

    @Before
    public void init() {
        MockitoAnnotations.initMocks(this);
    }

    @Test
    public void Test() {
        assertTrue(true);
    }
}
