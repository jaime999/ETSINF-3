import java.io.*;
import java.util.Enumeration;
import javax.servlet.ServletException;
import javax.servlet.http.*;

/**
 * Servlet implementation class carrito
 */
public class carrito2 extends HttpServlet {
	private static final long serialVersionUID = 1L;
    String preTituloHTML5 = "<!DOCTYPE html>\n<html>\n<head>\n"
    		+ "<meta http-equiv=\"Content-type\" content=\"text/html; charset=utf-8\" />";
    
    private boolean beginsWith(String prefijo, String grande) {
    	int fin = prefijo.length();
    	if (grande.length()<fin) return false;
    	for(int i = 0; i<fin; i++) {
    		if (grande.charAt(i)!=prefijo.charAt(i)) return false;}
    	return true;
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/plain");
		PrintWriter out = response.getWriter();
		HttpSession sesion = request.getSession(false);
		    // Ha de mostrar la lista de identificadores junto con sus contadores		
		if(sesion==null) {out.println("No hay identificadores que mostrar");}
		else {
			Enumeration<String> lista = sesion.getAttributeNames();
			if(lista==null) {out.println("No hay identificadores que mostrar");}
		      // El error anterior debería ser imposible porque toda sesión tiene carrito			
			else
			{while (lista.hasMoreElements())
				{String id=(String)lista.nextElement();
				if(beginsWith("compra_", id)) {
					id = id.replace("compra_", "");
					out.println("El contador de "+id+" vale "+sesion.getAttribute("compra_"+id));}
					}
				}
			}
		}
	

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		String id = request.getParameter("id");
		id = "compra_" + id;
		HttpSession sesion = request.getSession(true);
		    // Ha de actualizar el contador asociado a id		
		Integer n = (Integer) sesion.getAttribute(id);
		if (n==null) {n=new Integer(1);}
		else {n=new Integer(n.intValue()+1);}
		sesion.setAttribute(id, n);
		
		id = id.replace("compra_", ""); 
		out.println(preTituloHTML5 +"<title>Carrito</title></head>");
		out.println("<body><h1>Carrito</h1>");
		out.println("<p>El contador de "+id+" vale "+n+"</p>");
		out.println("</body></html>");
	}

}
