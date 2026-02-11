import 'dart:convert';

import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:flutter/widgets.dart';
import 'package:collection/collection.dart';
import 'package:http/http.dart' as http;

class CartProvider extends BaseProvider<Cart> {
  CartProvider() : super("cart");

  @override
  Cart fromJson(dynamic json) {
    return Cart.fromJson(json);
  }

  Future<void> deleteItem(int id) async {
    var url = "https://localhost:7093/api/Cart/DeleteItem/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.delete(uri, headers: headers);
    if (isValidResponse(response)) {
    } else {
      throw new Exception("Unknown error");
    }
  }

  Future<void> checkOut(int id) async {
    var url = "https://localhost:7093/api/Cart/CheckOut/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.post(uri, headers: headers);
    if (isValidResponse(response)) {
    } else {
      throw new Exception("Unknown error");
    }
  }

  Future<void> clearCart(int id) async {
    var url = "https://localhost:7093/api/Cart/ClearCart/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.delete(uri, headers: headers);
    if (isValidResponse(response)) {
    } else {
      throw new Exception("Unknown error");
    }
  }
}
