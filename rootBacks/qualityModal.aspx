<!-- Modal -->


        <div class="modal" id="qModal" tabindex="-1" role="dialog" aria-labelledby="qModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Закрыть</span></button>
                        <h4 class="modal-title" id="qModalLabel">Качество</h4>
                    </div>
                    <div class="modal-body">
                        <table  text-align: center" class="auto-style1">
                            <tr>


                                <th>Сор</th>
                                <th>Влажность</th>
                                <th>Белок</th>
                            </tr>
                            <tr>

                                <td>
                                    <asp:TextBox ID="TextBox1"  class="form-control" runat="server" Text='<%# Bind("sor") %>'  MaxLength="2"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" class="form-control" runat="server"  Text='<%# Bind("vlazhnost") %>'  MaxLength="2"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3"  class="form-control" runat="server" Text='<%# Bind("belok") %>'   MaxLength="2"></asp:TextBox>
                                </td>
                            </tr>


                        </table>
                       
                     
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Button1"  class="btn btn-primary" runat="server" Text="Применить" CausesValidation="False"  />
                      
                          <button type="button" class="btn btn-default" data-dismiss="modal">Отмена</button>
                    </div>
                </div>
            </div>
        </div>
