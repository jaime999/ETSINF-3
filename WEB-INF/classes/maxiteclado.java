//maxiteclado_rpfd

import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

/**
 * Servlet implementation class maxiteclado
 */
public class maxiteclado extends HttpServlet {
	private static final long serialVersionUID = 1L;
	int recuento;
	
	public void init(ServletConfig config) throws ServletException {
		super.init(config);
		try {
			FileReader fR = new FileReader("recuento.txt");
			BufferedReader bR = new BufferedReader(fR);
			String linea = bR.readLine();
			recuento = Integer.parseInt(linea);
			bR.close();
			return;
		} 
		
		catch (FileNotFoundException ignored) { }
		catch (IOException ignored) { }
		catch (NumberFormatException ignored) { }
		
		String linea = config.getInitParameter("fichero");
		if(linea != null) {
			recuento = Integer.parseInt(linea);
			return;
		}
		else {
			recuento = 0;
		}
	}
	
	protected void doGet(HttpServletRequest request,
		HttpServletResponse response) throws ServletException, IOException {
		HttpSession sesion = request.getSession(true);
		sesion.setAttribute("idTamaño", "");
		sesion.setAttribute("idFuente", "");
		String fichero = request.getServletContext().getRealPath("diseñoMaxiteclado.html");
		String linea;
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		FileReader f = new FileReader(fichero);
		BufferedReader b = new BufferedReader(f);
		while((linea = b.readLine()) != null) {
			out.print(linea);
		}
		b.close();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String fichero = request.getServletContext().getRealPath("diseñoMaxiteclado.html");
		String linea;
		HttpSession sesion = request.getSession(true);
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		FileReader f = new FileReader(fichero);
		BufferedReader b = new BufferedReader(f);
		String tamaño = request.getParameter("size");
		String tecla = request.getParameter("tecla");
		String fuente = request.getParameter("font");
		String idTamaño = "idTamaño";
		String idFuente = "idFuente";
		if(tecla==null) {
			tecla = "";
		}
		else {
			++recuento;
		}
		if(tamaño == null) {
			tamaño = (String) sesion.getAttribute(idTamaño);
		}
		if(fuente == null) {
			fuente = (String) sesion.getAttribute(idFuente);
		}
		sesion.setAttribute(idTamaño, tamaño);
		sesion.setAttribute(idFuente, fuente);
		while((linea = b.readLine()) != null) {
			if(linea.contains("<h1>Teclado avanzado")) {
				out.println("<div class='banda "+tamaño+" "+fuente+"'><h1>Teclado avanzado</h1></div>");
			}
			else if(linea.contains("Comenzamos")) {
				out.println("<p>&Uacute;ltima tecla pulsada: <span class='"+tamaño+" "+fuente+"' >"+tecla+"</span></p>");
			}
			else if(linea.contains("pulsando")) {
				out.println("<p>Recuento total: <span class='"+tamaño+" "+fuente+"' >"+recuento+"</span></p>");
			}
			else {
			out.print(linea);
			}
		}
		b.close();
	}
	
	public void destroy() {
		try {
			FileWriter fW = new FileWriter("recuento.txt");
			String linea = Integer.toString(recuento);
			fW.write(linea, 0, linea.length());
			fW.close();
			return;
		} catch (IOException e) { }
	}

}
