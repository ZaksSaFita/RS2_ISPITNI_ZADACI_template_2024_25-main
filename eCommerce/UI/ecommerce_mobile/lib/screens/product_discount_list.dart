import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/discount.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/discount_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/edit_discount.dart';
import 'package:ecommerce_mobile/screens/product_discount_add.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class DiscountScreen extends StatefulWidget {
  const DiscountScreen({super.key});

  @override
  State<DiscountScreen> createState() => _DiscountScreen();
}

class _DiscountScreen extends State<DiscountScreen> {
  late DiscountProvider discountProvider;

  TextEditingController searchController = TextEditingController();

  SearchResult<Discount>? data;
  bool isLoading = false;
  // @override
  // void didChangeDependencies() {
  //   super.didChangeDependencies();
  // }

  @override
  void initState() {
    super.initState();
    discountProvider = DiscountProvider();

    loadData(null);
  }

  void loadData(String? input) async {
    setState(() {
      isLoading = true;
    });
    var result = await discountProvider.get(filter: {
      "fts": input,
    });
    this.data = result;

    if (result.items != null && result.items!.isNotEmpty) {
      for (var element in result.items!) {
        print("itemi: ${element.product!.name}");
      }
    }

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (isLoading) {
      return MasterScreen(
        title: "Discount List",
        child: Center(
          child: Column(
            children: [_buildCartHeader(), Text("loading data...")],
          ),
        ),
      );
    }
    return MasterScreen(
      title: "Discount List",
      child: Center(
        child: Column(
          children: [
            _buildCartHeader(),
            _buildCartItems(),
            _buildCartSummary(),
          ],
        ),
      ),
    );
  }

  Widget _buildCartHeader() {
    return Padding(
        padding: const EdgeInsets.all(16.0),
        child: Row(
          children: [
            SearchBar(
              hintText: "Search by product name",
              controller: searchController,
              onChanged: (value) async {
                loadData(value);
              },
            ),
            SizedBox(
              width: 30,
            ),
            Expanded(
                child: ElevatedButton.icon(
              onPressed: () {
                Navigator.of(context).push(MaterialPageRoute(
                    builder: (context) => const ProductDiscountAdd(null)));
              },
              label: Text("Add discount"),
              icon: Icon(Icons.add),
            ))
          ],
        ));
  }

  Widget _buildCartItems() {
    if (data == null) {
      return const Expanded(
        child: Center(child: Text("No data")),
      );
    }
    if (data!.items == null || data!.items!.isEmpty) {
      return Expanded(
        child: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Icon(Icons.shopping_cart_outlined, size: 64, color: Colors.grey),
              SizedBox(height: 16),
              Text(
                "Your list is empty",
                style: TextStyle(fontSize: 18, color: Colors.grey),
              ),
            ],
          ),
        ),
      );
    }

    return Expanded(
      child: ListView.builder(
        itemCount: data!.items!.length,
        itemBuilder: (context, index) {
          final item = data!.items![index];
          return _buildCartItemCard(item);
        },
      ),
    );
  }

  Widget _buildCartItemCard(Discount item) {
    return GestureDetector(
      onTap: () {
        Navigator.of(context).push(
            MaterialPageRoute(builder: (context) => ProductDiscountAdd(item)));
      },
      child: Card(
        margin: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
        child: Padding(
          padding: EdgeInsets.all(12),
          child: Row(
            children: [
              // Product Image
              Container(
                height: 80,
                width: 80,
                child: item.product!.assets.firstOrNull == null
                    ? Placeholder()
                    : imageFromString(item.product!.assets.first.base64Content),
              ),
              SizedBox(width: 12),
              // Product Details
              Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      item.product!.name,
                      style: TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                    SizedBox(height: 4),
                    Row(
                      children: [
                        Text("Old Price: "),
                        Text(
                          " ${formatNumber(item.oldPrice)} \$",
                          style: TextStyle(
                              fontSize: 16,
                              fontWeight: FontWeight.bold,
                              color: Colors.grey,
                              decoration: TextDecoration.lineThrough),
                        ),
                      ],
                    ),
                    SizedBox(height: 8),
                    Row(
                      children: [
                        Text("Discount: "),
                        Text(
                          "${formatNumber(item.discount)} %",
                          style: TextStyle(
                              fontWeight: FontWeight.bold, color: Colors.red),
                        ),
                      ],
                    ),
                    SizedBox(height: 8),
                    Row(
                      children: [
                        Text("New Price: "),
                        Text(
                          " ${formatNumber(item.newPrice)} \$",
                          style: TextStyle(
                            fontSize: 16,
                            fontWeight: FontWeight.bold,
                            color: Colors.green,
                          ),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
              // Actions
              Column(
                children: [
                  Row(
                    children: [
                      Text("Valid from: "),
                      Text(
                        DateFormat("dd.MM.yyyy").format(item.validFrom!),
                        style: TextStyle(
                            fontWeight: FontWeight.bold, color: Colors.green),
                      ),
                    ],
                  ),
                  SizedBox(height: 8),
                  Row(
                    children: [
                      Text("Valid to: "),
                      Text(
                        DateFormat("dd.MM.yyyy").format(item.validTo!),
                        style: TextStyle(
                            fontWeight: FontWeight.bold, color: Colors.green),
                      ),
                    ],
                  ),
                  SizedBox(height: 8),
                  IconButton(
                    onPressed: () async {
                      await discountProvider.delete(item.id);
                      loadData(null);
                      setState(() {});
                    },
                    icon: Icon(Icons.delete_rounded, color: Colors.red),
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }

  double calculate() {
    double total = 0;

    if (data!.items != null && data!.items!.isNotEmpty) {
      for (var element in data!.items!) {
        total += element.oldPrice - element.newPrice;
      }
    }
    return total;
  }

  Widget _buildCartSummary() {
    if (data!.items!.isEmpty) {
      return SizedBox.shrink();
    }

    return Container(
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.grey[100],
        border: Border(top: BorderSide(color: Colors.grey[300]!)),
      ),
      child: Column(
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text(
                "Total discount:",
                style: TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.bold,
                ),
              ),
              Text(
                "${formatNumber(calculate())} \$",
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                  color: Colors.green,
                ),
              ),
            ],
          ),
        ],
      ),
    );
  }
}
