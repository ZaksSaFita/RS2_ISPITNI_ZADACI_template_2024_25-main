import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/user_favorite.dart';
import 'package:ecommerce_mobile/providers/auth_provider.dart';
import 'package:ecommerce_mobile/providers/favorite_provider.dart';
import 'package:ecommerce_mobile/providers/shop_provider.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class FavoriteList extends StatefulWidget {
  const FavoriteList({super.key});

  @override
  State<FavoriteList> createState() => _FavoriteList();
}

class _FavoriteList extends State<FavoriteList> {
  late FavoriteProvider favoriteProvider;
  late ShopProvider shopProvider;
  late CartProvider cartProvider;

  TextEditingController fromController = TextEditingController();
  TextEditingController toController = TextEditingController();
  var userId;
  SearchResult<UserFavorite>? data;
  bool isFavorite = false;
  DateTime? from;
  DateTime? to;

  @override
  void initState() {
    super.initState();
    favoriteProvider = FavoriteProvider();
    shopProvider = ShopProvider();
    cartProvider = context.read<CartProvider>();

    userId = AuthProvider.user?.id;
    loadData(null, null);
  }

  loadData(DateTime? from, DateTime? to) async {
    data = await favoriteProvider
        .get(filter: {"userId": userId, "from": from, "to": to});

    if (data!.items != null && data!.items!.isNotEmpty) {
      for (var element in data!.items!) {
        print("${element.id}");
      }
      isFavorite = true;
    }
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
        title: "Favorite List",
        child: Center(
          child: Column(
            children: [_buildSearch(), _buildList()],
          ),
        ));
  }

  Widget _buildList() {
    if (from != null && to != null) {
      if (from!.isAfter(to!)) {
        return Center(
          child: Text("Date From cant be higher then date to"),
        );
      }
    }
    return Expanded(
      child: DataTable(
          columns: const [
            DataColumn(label: Text("ID")),
            DataColumn(label: Text("Product name")),
            DataColumn(label: Text("Product price")),
            DataColumn(label: Text("Added at"))
          ],
          rows: data?.items
                  ?.map((e) => DataRow(cells: [
                        DataCell(Text("${e.id}")),
                        DataCell(Text("${e.product?.name}")),
                        DataCell(Text("${e.product?.price} \$")),
                        DataCell(
                            Text(DateFormat("dd.MM.yyyy").format(e.createdAt!)))
                      ]))
                  .toList() ??
              []),
    );
  }

  Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          children: [
            Expanded(
              child: TextField(
                  controller: fromController,
                  decoration: InputDecoration(
                    hintText: "From",
                    labelText: "From",
                    border: OutlineInputBorder(),
                  ),
                  onTap: () async {
                    final picked = await showDatePicker(
                        context: context,
                        firstDate: DateTime(200),
                        lastDate: DateTime(2100));
                    if (picked != null) {
                      from = picked;
                      fromController.text =
                          DateFormat("dd.MM.yyyy").format(from!);
                      await loadData(from, to);
                    }
                  }),
            ),
            SizedBox(width: 10),
            Expanded(
              child: TextField(
                  controller: toController,
                  decoration: InputDecoration(
                    hintText: "To",
                    labelText: "To",
                    border: OutlineInputBorder(),
                  ),
                  onTap: () async {
                    final picked = await showDatePicker(
                        context: context,
                        firstDate: DateTime(200),
                        lastDate: DateTime(2100));
                    if (picked != null) {
                      to = picked;
                      toController.text = DateFormat("dd.MM.yyyy").format(to!);
                      await loadData(from, to);
                    }
                  }),
            ),
            SizedBox(width: 10),
            TextButton.icon(
              onPressed: () async {
                fromController.text = "";
                toController.text = "";
                from = null;
                to = null;
                await loadData(from, to);
                setState(() {});
              },
              label: Text("Reset"),
              icon: Icon(Icons.restore),
            ),
            SizedBox(width: 10),
            ElevatedButton(
              onPressed: () async {
                for (var element in data!.items!) {
                  cartProvider.addToCart(element.product!);
                  var request = {"productId": element.productId, "quantity": 1};
                  await shopProvider.addToCart(userId, request);

                  await favoriteProvider.delete(element.id);
                }
                await loadData(from, to);
              },
              child: Text("Add to cart"),
            )
          ],
        ));
  }
}
