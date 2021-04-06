// CSD feb 2013 Juansa Sendra

public class Pool4 extends Pool { //kids cannot enter if there are instructors waiting to exit
    public int kids, instructors, iw;
    
    public void init(int ki, int cap) {}
    
    public synchronized void kidSwims() throws InterruptedException {
        while(((instructors == 0 || kids/instructors >= 2) || kids+instructors >= 5) || iw > 0) {
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
        iw++;
        while(kids > 0 && (instructors == 1 || kids/(instructors-1) >= 2)){
            log.waitingToRest();
            wait();
        }
        iw--;
        instructors--;
        log.resting();
        notifyAll();
    }
}
