namespace proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //conectar botones
            btnAngulos.Click += btnAngulos_Click;
            btnKramer.Click += btnKramer_Click;
            btnCajero.Click += btnCajero_Click;
            btnHerreria.Click += btnHerreria_Click;
            btnPromedio.Click += btnPromedio_Click;
            btnOrdenamiento.Click += btnOrdenamiento_Click;
            btnPlano.Click += btnPlano_Click;
            btnCreditos.Click += btnCreditos_Click;
            btnSalir.Click += btnSalir_Click;
        }

        //===================================================
        // 1. ÀNGULOS AGUDOS
        //===================================================

        private void btnAngulos_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();


            ventana.Text = "Ángulos Agudos";
            ventana.Size = new Size(400, 300);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.LightPink;

            Label titulo = new Label();
            titulo.Text = "Ángulos Agudos";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(120, 25);

            Label etiqueta = new Label();
            etiqueta.Text = "Ingrese el valor del ángulo:";
            etiqueta.AutoSize = true;
            etiqueta.Location = new Point(50, 90);

            TextBox txtAngulo = new TextBox();
            txtAngulo.Location = new Point(200, 85);
            txtAngulo.Width = 120;

            Button Calcular = new Button();
            Calcular.Text = "Calcular";
            Calcular.Location = new Point(160, 135);

            Label resultado = new Label();
            resultado.AutoSize = true;
            resultado.Location = new Point(80, 190);
            resultado.Font = new Font("Arial", 11, FontStyle.Bold);

            Calcular.Click += (s, ev) =>
            {
                double angulo;

                if (double.TryParse(txtAngulo.Text, out angulo))
                {
                    if (angulo > 0 && angulo < 90)
                    {
                        resultado.Text = "El ángulo es agudo.";
                    }
                    else
                    {
                        resultado.Text = "El ángulo no es agudo.";
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE UN NÙMERO VÀLIDO.");
                }
            };

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(etiqueta);
            ventana.Controls.Add(txtAngulo);
            ventana.Controls.Add(Calcular);
            ventana.Controls.Add(resultado);

            ventana.ShowDialog();
        }


        //=================================================================
        // 2. DETERMINANTE REGLA KRAMER
        //=================================================================

        private void btnKramer_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();


            ventana.Text = "Determinante Regla Kramer";
            ventana.Size = new Size(500, 400);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.LightBlue;


            Label titulo = new Label();
            titulo.Text = "REGLA DE KRAMER";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(160, 20);


            Label sistema = new Label();
            sistema.Text = "AX + BY = C\r\nDX + EY = F";
            sistema.AutoSize = true;
            sistema.Location = new Point(200, 60);


            TextBox A = Caja(50, 130);
            TextBox B = Caja(130, 130);
            TextBox C = Caja(210, 130);

            TextBox D = Caja(50, 180);
            TextBox E = Caja(130, 180);
            TextBox F = Caja(210, 180);

            Button calcular = new Button();
            calcular.Text = "Resolver";
            calcular.Location = new Point(180, 230);

            Label resultado = new Label();
            resultado.AutoSize = true;
            resultado.Location = new Point(100, 280);
            resultado.Font = new Font("Arial", 11, FontStyle.Bold);

            calcular.Click += (s, ev) =>
            {
                double a, b, c, d, e, f;
                if (double.TryParse(A.Text, out a) &&
                    double.TryParse(B.Text, out b) &&
                    double.TryParse(C.Text, out c) &&
                    double.TryParse(D.Text, out d) &&
                    double.TryParse(E.Text, out e) &&
                    double.TryParse(F.Text, out f))
                {
                    double determinante = (a * e) - (b * d);

                    if (determinante == 0)
                    {
                        resultado.Text = "No existe solución única.";
                    }
                    else
                    {
                        double x = ((c * e) - (b * f)) / determinante;
                        double y = ((a * f) - (c * d)) / determinante;

                        resultado.Text = "X = " + x.ToString("0.00") + "    Y = " + y.ToString("0.00");
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE TODOS LOS VALORES.");
                }
            };


            ventana.Controls.Add(titulo);
            ventana.Controls.Add(sistema);


            ventana.Controls.Add(A);
            ventana.Controls.Add(B);
            ventana.Controls.Add(C);
            ventana.Controls.Add(D);
            ventana.Controls.Add(E);
            ventana.Controls.Add(F);


            ventana.Controls.Add(calcular);
            ventana.Controls.Add(resultado);

            ventana.ShowDialog();
        }

        //========================================================
        // 3. CAJERO DEL BANCO
        //========================================================

        private void btnCajero_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            ventana.Text = "Cajero del Banco";
            ventana.Size = new Size(450, 350);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.LightGreen;

            // TÍTULO
            Label titulo = new Label();
            titulo.Text = "Cajero del banco";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(130, 20);

            // SALDO
            Label saldo = new Label();
            saldo.Text = "Saldo:";
            saldo.Location = new Point(80, 90);
            saldo.AutoSize = true;

            TextBox txSaldo = new TextBox();
            txSaldo.Location = new Point(180, 87);
            txSaldo.Width = 120;

            // CANTIDAD A RETIRAR
            Label retiro = new Label();
            retiro.Text = "Cantidad a retirar:";
            retiro.Location = new Point(80, 130);
            retiro.AutoSize = true;

            TextBox txtRetiro = new TextBox();
            txtRetiro.Location = new Point(180, 127);
            txtRetiro.Width = 120;

            // BOTÓN RETIRAR
            Button retirar = new Button();
            retirar.Text = "Retirar";
            retirar.Location = new Point(180, 175);
            retirar.Width = 80;

            // RESULTADO
            Label resultado = new Label();
            resultado.AutoSize = true;
            resultado.Location = new Point(80, 230);
            resultado.Font = new Font("Arial", 11, FontStyle.Bold);

            // BOTÓN RETIRAR
            retirar.Click += (s, ev) =>
            {
                double dinero;
                double cantidad;

                if (double.TryParse(txSaldo.Text, out dinero) &&
                    double.TryParse(txtRetiro.Text, out cantidad))
                {
                    if (cantidad <= 0)
                    {
                        resultado.Text = "Cantidad inválida.";
                    }
                    else if (cantidad > dinero)
                    {
                        resultado.Text = "Fondos insuficientes.";
                    }
                    else
                    {
                        dinero -= cantidad;

                        resultado.Text =
                            "Retiro realizado.\r\n" +
                            "Saldo restante: $" +
                            dinero.ToString("0.00");
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE NÚMEROS VÁLIDOS.");
                }
            };

            // AGREGAR CONTROLES
            ventana.Controls.Add(titulo);
            ventana.Controls.Add(saldo);
            ventana.Controls.Add(txSaldo);
            ventana.Controls.Add(retiro);
            ventana.Controls.Add(txtRetiro);
            ventana.Controls.Add(retirar);
            ventana.Controls.Add(resultado);

            ventana.ShowDialog();
        }

        //===============================================================
        // 4. HERRERÍA
        //===============================================================

        private void btnHerreria_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            ventana.Text = "Herrería";
            ventana.Size = new Size(450, 350);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.LightYellow;

            Label titulo = new Label();
            titulo.Text = "Herrería";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(170, 25);

            Label largo = new Label();
            largo.Text = "Largo:";
            largo.Location = new Point(60, 90);
            largo.AutoSize = true;

            TextBox txtLargo = new TextBox();
            txtLargo.Location = new Point(180, 87);

            Label ancho = new Label();
            ancho.Text = "Ancho:";
            ancho.Location = new Point(60, 130);
            ancho.AutoSize = true;

            TextBox txtAncho = new TextBox();
            txtAncho.Location = new Point(180, 127);

            Button calcular = new Button();
            calcular.Text = "Calcular";
            calcular.Location = new Point(160, 175);

            Label resultado = new Label();
            resultado.AutoSize = true;
            resultado.Location = new Point(80, 225);

            calcular.Click += (s, ev) =>
            {
                double l;
                double a;

                if (double.TryParse(txtLargo.Text, out l) &&
                    double.TryParse(txtAncho.Text, out a))
                {
                    double area = l * a;
                    double perimetro = 2 * (l + a);

                    resultado.Text =
                        "Área: " + area.ToString("0.00") +
                        "\r\nPerímetro: " + perimetro.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("INGRESE NÙMEROS VÀLIDOS.");
                }
            };

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(largo);
            ventana.Controls.Add(txtLargo);
            ventana.Controls.Add(ancho);
            ventana.Controls.Add(txtAncho);
            ventana.Controls.Add(calcular);
            ventana.Controls.Add(resultado);

            ventana.ShowDialog();
        }

        //===============================================================
        // 5. PROMEDIO DE VENTAS
        //===============================================================

        private void btnPromedio_Click(object sender, EventArgs e)
        {

            Form ventana = new Form();

            ventana.Text = "Promedio Ventas";
            ventana.Size = new Size(450, 400);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.LightCyan;

            Label titulo = new Label();
            titulo.Text = "PROMEDIO DE VENTAS";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(100, 25);

            Label ventasLabel = new Label();
            ventasLabel.Text = "Ingrese 5 ventas:";
            ventasLabel.AutoSize = true;
            ventasLabel.Location = new Point(160, 70);

            TextBox[] Ventas = new TextBox[5];

            for (int i = 0; i < 5; i++)
            {
                Ventas[i] = new TextBox();
                Ventas[i].Location =
                    new Point(160, 100 + (i * 30));
                Ventas[i].Width = 100;


                ventana.Controls.Add(Ventas[i]);
            }

            Button calcular = new Button();
            calcular.Text = "Calcular";
            calcular.Location = new Point(145, 290);

            calcular.Click += (s, ev) =>
            {
                double suma = 0;

                for (int i = 0; i < 5; i++)
                {
                    double venta;

                    if (!double.TryParse(Ventas[i].Text, out venta))
                    {
                        MessageBox.Show("INGRESE CORRECTAMENTE LAS VENTAS.");
                        return;
                    }

                    suma += venta;
                }

                double promedio = suma / 5;

                MessageBox.Show(
                    "Total: $" + suma.ToString("0.00") +
                    "\r\nPromedio: $" +
                    promedio.ToString("0.00"));

            };

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(ventasLabel);
            ventana.Controls.Add(calcular);

            ventana.ShowDialog();
        }

        //===============================================================
        // 6. ORDENAMIENTO
        //===============================================================

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            ventana.Text = "Ordenamiento";
            ventana.Size = new Size(500, 600);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.MistyRose;

            Label titulo = new Label();
            titulo.Text = "ORDENAMIENTO";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(170, 25);

            Label instruccion = new Label();
            instruccion.Text = "Ingrese 10 números:";
            instruccion.AutoSize = true;
            instruccion.Location = new Point(190, 70);

            TextBox[] numeros = new TextBox[10];

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = new TextBox();

                numeros[i].Location =
                    new Point(190, 100 + (i * 30));

                numeros[i].Width = 100;

                ventana.Controls.Add(numeros[i]);
            }

            Button ordenar = new Button();
            ordenar.Text = "Ordenar";
            ordenar.Width = 100;
            ordenar.Height = 30;
            ordenar.Location = new Point(190, 410);

            Label resultado = new Label();
            resultado.AutoSize = false;
            resultado.Size = new Size(420, 80);
            resultado.Location = new Point(40, 460);
            resultado.Font = new Font("Arial", 11, FontStyle.Bold);

            ordenar.Click += (s, ev) =>
            {
                int[] valores = new int[10];
                bool error = false;

                for (int i = 0; i < 10; i++)
                {
                    int valor;

                    if (int.TryParse(numeros[i].Text, out valor))
                    {
                        valores[i] = valor;
                    }
                    else
                    {
                        MessageBox.Show(
                            "INGRESE SOLO NÚMEROS ENTEROS."
                        );

                        error = true;
                        break;
                    }
                }

                if (!error)
                {
                    Array.Sort(valores);

                    resultado.Text =
                        "Ordenados: " +
                        string.Join(", ", valores);
                }
            };

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(instruccion);
            ventana.Controls.Add(ordenar);
            ventana.Controls.Add(resultado);

            ventana.ShowDialog();
        }

        //===============================================================
        // 7. PLANO CARTESIANO
        //===============================================================

        private void btnPlano_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            ventana.Text = "Plano Cartesiano";
            ventana.Size = new Size(500, 450);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.Lavender;

            Label titulo = new Label();
            titulo.Text = "PLANO CARTESIANO";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(160, 25);

            Label instrucciones = new Label();
            instrucciones.Text = "Ingrese las coordenadas (x, y):";
            instrucciones.AutoSize = true;
            instrucciones.Location = new Point(140, 70);

            TextBox txtX = new TextBox();
            txtX.Location = new Point(150, 110);
            txtX.Width = 100;

            TextBox txtY = new TextBox();
            txtY.Location = new Point(270, 110);
            txtY.Width = 100;

            Button graficar = new Button();
            graficar.Text = "Graficar";
            graficar.Location = new Point(200, 150);

            PictureBox plano = new PictureBox();
            plano.Location = new Point(50, 200);
            plano.Size = new Size(400, 200);
            plano.BorderStyle = BorderStyle.Fixed3D;
            plano.BackColor = Color.White;

            graficar.Click += (s, ev) =>
            {
                int x, y;

                if (int.TryParse(txtX.Text, out x) &&
                    int.TryParse(txtY.Text, out y))
                {
                    Bitmap bm = new Bitmap(
                        plano.Width,
                        plano.Height
                    );

                    Graphics g = Graphics.FromImage(bm);

                    // Fondo blanco
                    g.Clear(Color.White);

                    // Centro del plano
                    int centroX = plano.Width / 2;
                    int centroY = plano.Height / 2;

                    // Escala: cada unidad equivale a 10 píxeles
                    int escala = 10;

                    // =================================================
                    // DIBUJAR CUADRÍCULA
                    // =================================================

                    Pen cuadricula = new Pen(Color.LightGray);

                    for (int i = centroX; i < plano.Width; i += escala)
                    {
                        g.DrawLine(
                            cuadricula,
                            i,
                            0,
                            i,
                            plano.Height
                        );
                    }

                    for (int i = centroX; i > 0; i -= escala)
                    {
                        g.DrawLine(
                            cuadricula,
                            i,
                            0,
                            i,
                            plano.Height
                        );
                    }

                    for (int i = centroY; i < plano.Height; i += escala)
                    {
                        g.DrawLine(
                            cuadricula,
                            0,
                            i,
                            plano.Width,
                            i
                        );
                    }

                    for (int i = centroY; i > 0; i -= escala)
                    {
                        g.DrawLine(
                            cuadricula,
                            0,
                            i,
                            plano.Width,
                            i
                        );
                    }

                    // =================================================
                    // DIBUJAR EJES
                    // =================================================

                    g.DrawLine(
                        Pens.Black,
                        0,
                        centroY,
                        plano.Width,
                        centroY
                    );

                    g.DrawLine(
                        Pens.Black,
                        centroX,
                        0,
                        centroX,
                        plano.Height
                    );

                    // =================================================
                    // DIBUJAR NÚMEROS
                    // =================================================

                    for (int i = -20; i <= 20; i++)
                    {
                        if (i != 0)
                        {
                            int posicionX =
                                centroX + (i * escala);

                            if (posicionX >= 0 &&
                                posicionX < plano.Width)
                            {
                                g.DrawString(
                                    i.ToString(),
                                    new Font("Arial", 7),
                                    Brushes.Black,
                                    posicionX - 5,
                                    centroY + 3
                                );
                            }
                        }
                    }

                    for (int i = -10; i <= 10; i++)
                    {
                        if (i != 0)
                        {
                            int posicionY =
                                centroY - (i * escala);

                            if (posicionY >= 0 &&
                                posicionY < plano.Height)
                            {
                                g.DrawString(
                                    i.ToString(),
                                    new Font("Arial", 7),
                                    Brushes.Black,
                                    centroX + 3,
                                    posicionY - 5
                                );
                            }
                        }
                    }

                    // =================================================
                    // CALCULAR POSICIÓN DEL PUNTO
                    // =================================================

                    int puntoX =
                        centroX + (x * escala);

                    int puntoY =
                        centroY - (y * escala);

                    // =================================================
                    // GRAFICAR PUNTO
                    // =================================================

                    int tamaño = 8;

                    g.FillEllipse(
                        Brushes.Red,
                        puntoX - tamaño / 2,
                        puntoY - tamaño / 2,
                        tamaño,
                        tamaño
                    );

                    // Mostrar coordenadas
                    g.DrawString(
                        "(" + x + ", " + y + ")",
                        new Font("Arial", 10, FontStyle.Bold),
                        Brushes.Red,
                        puntoX + 8,
                        puntoY - 15
                    );

                    // Mostrar imagen
                    plano.Image = bm;

                    g.Dispose();
                }
                else
                {
                    MessageBox.Show(
                        "INGRESE COORDENADAS VÁLIDAS."
                    );
                }
            };

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(instrucciones);
            ventana.Controls.Add(txtX);
            ventana.Controls.Add(txtY);
            ventana.Controls.Add(graficar);
            ventana.Controls.Add(plano);

            ventana.ShowDialog();
        }

        //===============================================================
        // 8. CRÉDITOS
        //===============================================================

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            ventana.Text = "Créditos";
            ventana.Size = new Size(400, 400);
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BackColor = Color.Beige;


            Label titulo = new Label();
            titulo.Text = "CRÉDITOS";
            titulo.Font = new Font("Arial", 16, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(140, 25);

            Label credito1 = new Label();
            credito1.Text = "Proyecto desarrollado por:";
            credito1.AutoSize = true;
            credito1.Location = new Point(100, 70);

            Label nombre1 = new Label();
            nombre1.Text = "- Nombre del Estudiante 1";
            nombre1.AutoSize = true;
            nombre1.Location = new Point(120, 110);

            Label nombre2 = new Label();
            nombre2.Text = "- Nombre del Estudiante 2";
            nombre2.AutoSize = true;
            nombre2.Location = new Point(120, 140);

            Label nombre3 = new Label();
            nombre3.Text = "- Nombre del Estudiante 3";
            nombre3.AutoSize = true;
            nombre3.Location = new Point(120, 170);

            Label nombre4 = new Label();
            nombre4.Text = "- Nombre del Estudiante 4";
            nombre4.AutoSize = true;
            nombre4.Location = new Point(120, 200);

            Label nombre5 = new Label();
            nombre5.Text = "- Nombre del Estudiante 5";
            nombre5.AutoSize = true;
            nombre5.Location = new Point(120, 230);

            Button cerrar = new Button();
            cerrar.Text = "Cerrar";
            cerrar.Location = new Point(160, 280);

            cerrar.Click += (s, ev) => ventana.Close();

            ventana.Controls.Add(titulo);
            ventana.Controls.Add(credito1);
            ventana.Controls.Add(nombre1);
            ventana.Controls.Add(nombre2);
            ventana.Controls.Add(nombre3);
            ventana.Controls.Add(nombre4);
            ventana.Controls.Add(nombre5);
            ventana.Controls.Add(cerrar);

            ventana.ShowDialog();
        }

        //===============================================================
        // 9. SALIR
        //===============================================================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private TextBox Caja(int x, int y)
        {
            TextBox tb = new TextBox();
            tb.Location = new Point(x, y);
            tb.Width = 60; // ajusta el ancho si lo necesitas
            return tb;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}









