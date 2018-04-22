//Instance of anonymous inner class passed as parameter:
this.gridPane.widthProperty().addListener(new ChangeListener<Number>() {
     @Override 
     public void changed(ObservableValue<? extends Number> observable, Number oldValue, final Number newValue) {
          drawGrid();
     }
});

//Creating instance of anonymous inner class assigned to variable that is passed as parameter:
ChangeListener<Number> changeListener = new ChangeListener<Number>() {
     @Override 
     public void changed(ObservableValue<? extends Number> observable, Number oldValue, final Number newValue) {
          drawGrid();
     } 
};

this.gridPane.widthProperty().addListener(changeListener);

//Creating instance of class that implements interface and passing it as parameter:
public class SizeChangeListener<T> implements ChangeListener<T> {

     @Override
     public void changed(ObservableValue<? extends T> observable, T oldValue, T newValue) {
          System.out.println("Change occurred.");
     }
}

this.gridPane.widthProperty().addListener(new SizeChangeListener());

//Passing a lambda expression as a parameter:
this.gridPane.widthProperty().addListener((ObservableValue<? extends Number> observable, Number oldValue, final Number newValue) -> {
     drawGrid();
});

//Assigning a lamba expression to a variable that is passed as a parameter:
ChangeListener<Number> lambdaChangeListener = (ObservableValue<? extends Number> observable, Number oldValue, final Number newValue) -> {
     drawGrid();
};

this.gridPane.widthProperty().addListener(lambdaChangeListener);
