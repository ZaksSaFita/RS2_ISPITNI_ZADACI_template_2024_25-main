import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/discount.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/discount_provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';
import 'package:ecommerce_mobile/screens/product_discount_list.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';

class ProductDiscountAdd extends StatefulWidget {
  final Discount? item;
  const ProductDiscountAdd(this.item, {super.key});

  @override
  State<ProductDiscountAdd> createState() => _ProductDiscountAdd();
}

class _ProductDiscountAdd extends State<ProductDiscountAdd> {
  late ProductProvider productProvider;
  late DiscountProvider discountProvider;

  bool get isEdit => widget.item != null;
  Map<String, dynamic> _initalValue = {};
  SearchResult<Product>? products;
  int? selectedValue;
  double selectedDiscount = 0;
  bool isLoading = true;
  DateTime? validFrom;
  DateTime? validTo;
  final formKey = GlobalKey<FormBuilderState>();

  TextEditingController discountController = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    productProvider = ProductProvider();
    discountProvider = DiscountProvider();
    if (isEdit && widget.item != null) {
      discountController.text = widget.item!.discount.toString();
      _initalValue = {
        "product": widget.item!.product?.id,
        // "discount": widget.item!.discount.toString(),
        "validFrom": widget.item!.validFrom,
        "validTo": widget.item!.validTo,
      };
    }

    loadData();
  }

  @override
  Widget build(BuildContext context) {
    if (isLoading) {
      return MasterScreen(
        title: "Add Discount",
        child: Center(
          child: Column(
            children: [Text("loading data")],
          ),
        ),
      );
    }
    return MasterScreen(
      title: "Add Discount",
      child: Center(
        child: Column(
          children: [_buildForm()],
        ),
      ),
    );
  }

  void loadData() async {
    var data = await productProvider.get();
    products = data;
    setState(() {
      isLoading = false;
    });
  }

  String? errorDrop;
  String? errorText;
  String? errorFrom;
  String? errorTo;

  Widget _buildForm() {
    return Container(
      width: 600,
      height: 600,
      decoration: BoxDecoration(border: Border.all()),
      padding: EdgeInsets.all(10),
      child: FormBuilder(
        initialValue: _initalValue,
        key: formKey,
        child: Column(
          children: [
            FormBuilderDropdown(
              decoration: InputDecoration(hintText: "Select Product"),
              name: "product",
              items: products!.items!
                  .map((e) =>
                      DropdownMenuItem(value: e.id, child: Text("${e.name}")))
                  .toList(),
              onChanged: (value) {
                selectedValue = value;
                print(selectedValue);
                setState(() {});
              },
              validator: FormBuilderValidators.required(
                  errorText: "odaberite product", checkNullOrEmpty: true),
            ),
            SizedBox(
              height: 10,
              child: Text(errorDrop != null ? "$errorDrop" : ""),
            ),
            FormBuilderTextField(
              name: "discount",
              decoration: InputDecoration(hintText: "input discount"),
              inputFormatters: [
                FilteringTextInputFormatter.digitsOnly,
                LengthLimitingTextInputFormatter(3)
              ],
              controller: discountController,
              validator: FormBuilderValidators.compose([
                FormBuilderValidators.required(errorText: "unesite discount"),
                FormBuilderValidators.numeric(errorText: "samo brojevi"),
                FormBuilderValidators.min(1, errorText: "min je 1"),
                FormBuilderValidators.max(100, errorText: "max je 100")
              ]),
            ),
            SizedBox(
              height: 20,
              child: Text(
                errorText != null ? "$errorText" : "",
                style: TextStyle(color: Colors.red),
              ),
            ),
            const Text("Valid From"),
            const SizedBox(height: 8),
            FormBuilderDateTimePicker(
              name: 'validFrom',
              inputType: InputType.date,
              decoration: const InputDecoration(
                border: OutlineInputBorder(),
              ),
              initialDate: DateTime.now(),
              firstDate: DateTime(2000),
              lastDate: DateTime(2100),
              validator: FormBuilderValidators.required(
                  errorText: "Odaberite datum od kada važi popust"),
            ),
            const SizedBox(height: 16),
            const Text("Valid To"),
            const SizedBox(height: 8),
            FormBuilderDateTimePicker(
              name: 'validTo',
              inputType: InputType.date,
              decoration: const InputDecoration(
                border: OutlineInputBorder(),
              ),
              initialDate: DateTime.now(),
              firstDate: DateTime(2000),
              lastDate: DateTime(2100),
              validator: FormBuilderValidators.required(
                  errorText: "Odaberite datum do kada važi popust"),
            ),
            const SizedBox(height: 24),
            Center(
              child: ElevatedButton(
                onPressed: () async {
                  // Validacija forme
                  if (formKey.currentState?.saveAndValidate() ?? false) {
                    final values = formKey.currentState!.value;

                    // Provjera da validTo >= validFrom
                    DateTime validFrom = values['validFrom'];
                    DateTime validTo = values['validTo'];
                    if (validTo.isBefore(validFrom)) {
                      showDialog(
                        context: context,
                        builder: (_) => AlertDialog(
                          title: const Text("Greška"),
                          content: const Text(
                              "Datum do ne može biti prije datuma od!"),
                          actions: [
                            TextButton(
                              onPressed: () => Navigator.pop(context),
                              child: const Text("OK"),
                            )
                          ],
                        ),
                      );
                      return;
                    }

                    // Podaci su validni → poziv API
                    final body = {
                      "productId": values['product'],
                      "discount": values['discount'],
                      "validFrom": validFrom.toIso8601String(),
                      "validTo": validTo.toIso8601String(),
                    };

                    // Primjer: poziv API funkcije
                    if (isEdit) {
                      await discountProvider.update(widget.item!.id, body);
                    } else {
                      await discountProvider.insert(body);
                    }

                    ScaffoldMessenger.of(context).showSnackBar(
                        const SnackBar(content: Text("Discount saved!")));

                    Navigator.of(context).push(MaterialPageRoute(
                        builder: (context) => const DiscountScreen()));
                  } else {
                    // Forma nije validna
                    ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
                        content: Text("Popunite sve obavezne podatke")));
                  }
                },
                child: const Text("Save Discount"),
              ),
            )
          ],
        ),
      ),
    );
  }
}
