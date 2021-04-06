// CSD feb 2015 Juansa Sendra

public class Pool1 extends Pool {   //no kids alone
    public int kids, instructors;
    
    public void init(int ki, int cap) {}
    
    public synchronized void kidSwims() throws InterruptedException {
        while(instructors == 0) {
            log.waitingToSwim();
            wait();
        }
        kids++;
        log.swimming();
        notifyAll();
    }
    
    public void kidRests() throws InterruptedException {
        kids--;
        log.resting();
    }
        
    public void instructorSwims() throws InterruptedException {
        instructors++;
        log.swimming();
    }
    
    public synchronized void instructorRests() throws InterruptedException{
        while(kids > 0 && instructors == 1){
            log.waitingToRest();
            wait();
        }
        instructors--;
        log.resting();
        notifyAll();
    }
}
