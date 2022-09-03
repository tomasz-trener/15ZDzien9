<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyAPI.aspx.cs" Inherits="P02AplikacjaZawodnicy.ZawodnicyAPI" %>

     <div class="card">
              <div class="card-header">
                <h4 class="card-title"> Simple Table</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Imie i Nazwisko
                      </th>
                      <th>
                        Kraj
                      </th>
                      <th>
                        Miasto
                      </th>
                      <th >
                        Wzrost
                      </th>
                    </thead>
                    <tbody>
                       
                        <%
                            foreach (var z in Zawodnicy)
                            { %>

                            <tr data-id="<%= z.Id_zawodnika %>">
                                <td><%= z.Imie + " " + z.Nazwisko %></td>
                                <td><%= z.Kraj %></td>
                                <td><%= z.Miasto %></td>
                                <td><%= z.Wzrost %></td>
                            </tr>

                        <%  }
                            %>

                    </tbody>
                  </table>
                </div>
              </div>
            </div>