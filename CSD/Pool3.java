// CSD feb 2015 Juansa Sendra

public class Pool3 extends Pool { //max capacity
    public int kids, instructors;
    
    public void init(int ki, int cap) {}
    
    public synchronized void kidSwims() throws InterruptedException {
        while((instructors == 0 || kids/instructors >= 2) || kids+instructors >= 5) {
            log.waitingToSwim();
            wait();
        }
        kids++;
        log.swimming();
        notifyAll();
    }
    
    public synchronized void kidRests() throws InterruptedException {
        kids--;
        log.resting();
        notifyAll();
    }
        
    public synchronized void instructorSwims() throws InterruptedException {
        while(kids+instructors >= 5){
            log.waitingToSwim();
            wait();
        }
        instructors++;
        log.swimming();
        notifyAll();
    }
    
    public synchronized void instructorRests() throws InterruptedException{
        while(kids > 0 && (instructors == 1 || kids/(instructors-1) >= 2)){
            log.waitingToRest();
            wait();
        }
        instructors--;
        log.resting();
        notifyAll();
    }
}
