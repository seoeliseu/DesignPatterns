using TemplateMethod;

var faturamentoClienteCPF = new FaturamentoClienteCPF();
var faturamentoClienteCNPJ = new FaturamentoClienteCNPJ();

faturamentoClienteCPF.Faturar();
faturamentoClienteCNPJ.Faturar();