<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EdycjaZawodnika.aspx.cs" Inherits="P02AplikacjaZawodnicy.EdycjaZawodnika" %>



<div class="card">
              <div class="card-header">
                <h5 class="title">Edit Profile</h5>
              </div>
              <div class="card-body">
                <form runat="server">
                  <div class="row">
                    <div class="col-md-6 pr-1">
                      <div class="form-group">
                        <label>Imie</label>
                        <%--<input type="text" id="txtImie" class="form-control" placeholder="Imie" value="<%= Zawodnik.Imie %>">--%>
                        
                        <asp:TextBox ID="txtImie" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                          </div>
                    </div>
                    <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label for="exampleInputEmail1">Nazwisko</label>
                        <%--<input type="email" class="form-control" placeholder="Nazwisko" value="<%= Zawodnik.Nazwisko %>">--%>
                      <asp:TextBox ID="txtNazwisko" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                          
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-6 pr-1">
                      <div class="form-group">
                        <label>Kraj</label>
                        <%--<input type="text" class="form-control"  placeholder="Kraj" value="<%= Zawodnik.Kraj %>">--%>
                           <asp:TextBox ID="txtKraj" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                      </div>
                    </div>
                    <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Miasto</label>
                        <%--<input type="text" class="form-control" placeholder="Miasto" value="<%= Zawodnik.Miasto %>">--%>
                           <asp:TextBox ID="txtMiasto" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                      </div>
                    </div>
                  </div>
 
                  <div class="row">
                    <div class="col-md-4 pr-1">
                      <div class="form-group">
                        <label>Waga</label>
                        <%--<input type="text" class="form-control" placeholder="Waga" value="<%= Zawodnik.Waga %>">--%>
                           <asp:TextBox ID="txtWaga" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                      </div>
                    </div>
                    <div class="col-md-4 px-1">
                      <div class="form-group">
                        <label>Wzrost</label>

   
                        <%--<input type="text" class="form-control" placeholder="Wzrost" value="<%= Zawodnik.Wzrost %>">--%>
                           <asp:TextBox ID="txtWzrost" CssClass="form-control" runat="server"></asp:TextBox> 
                      
                      </div>
                    </div>
                    <div class="col-md-4 pl-1">
                      <div class="form-group">
                        <label>Data Ur</label>
                        <%--<input type="text" class="form-control" id="dataur"="Data Ur" value="<%= Zawodnik.DataUr?.ToString("dd-MM-yyyy") %>">--%>
                           <asp:TextBox ID="txtDataUr" CssClass="form-control" runat="server"></asp:TextBox> 
                     
                                                                 
                      </div>
                    </div>
                  </div>

                    <button id="btnZapisz" class="btn btn-primary btn-block">Zapisz</button>
                    <button id="btnUsun" class="btn btn-primary btn-block">Usuń</button>
                   <%-- <asp:Button ID="btnZapisz" OnClick="btnZapisz_Click" CssClass="btn btn-primary btn-block" runat="server" Text="Zapisz" />
                    <asp:Button ID="btnUsun" Visible="false" OnClick="btnUsun_Click" CssClass="btn btn-primary btn-block" runat="server" Text="Usuń" />--%>

                </form>
              </div>
            </div>

