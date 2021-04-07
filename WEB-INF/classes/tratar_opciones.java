import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Calendar;
import java.util.Date;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class tratar_opciones
 */
public class tratar_opciones extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String text = request.getParameter("opcion");
		if(text == "") {
			response.sendError(404);
		}
		else {
			try {
			
				int opc = Integer.parseInt(text);
				if(opc == 1) {
					String fichero = request.getServletContext().getRealPath("pagina_literal.html");
					String linea;
					Calendar calendario = Calendar.getInstance();
					Date fecha = calendario.getTime();
					response.setContentType("text/html");
					PrintWriter out = response.getWriter();
					FileReader f = new FileReader(fichero);
					BufferedReader b = new BufferedReader(f);
					while((linea = b.readLine())!=null) {
						if(linea.contains("poned_aqui_la_fecha_y_los_nombres")) {
							out.println("<p>Hoy es " +fecha +" , y me llamo Jaime Martínez Sánchez");
						}
						else {
							out.println(linea);
						}
					}
					b.close();
				}
				else if(opc == 2) {
					response.sendRedirect("http://w3c.es");
			
				}
				else {
					response.sendError(404);
				}
			} catch (NumberFormatException e) {
				response.sendError(404);
			}
		}
	}

}
