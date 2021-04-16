/**
 * @file  tiledb_cpp_api_schema_base.h
 *
 * @author Ravi Gaddipati
 *
 * @section LICENSE
 *
 * The MIT License
 *
 * @copyright Copyright (c) 2017-2020 TileDB, Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 *
 * @section DESCRIPTION
 *
 * This file declares the C++ API for the TileDB Schema base class.
 */

#ifndef TILEDB_CPP_API_SCHEMA_BASE_H
#define TILEDB_CPP_API_SCHEMA_BASE_H

#include "tiledb_cxx_deleter.h"
#include <map> 
#include <unordered_map>

namespace tiledb {

class Attribute;
class Context;
class Compressor;

/**
 * Base class for TileDB schemas. This is intended
 * for all array-backed stores.
 */
class Schema {
 public:
  const std::shared_ptr<tiledb::Context>& context() {
    return ctx_;
  }

  /** Add multiple attributes. **/
  template <typename... Args>
  tiledb::Schema& add_attributes(Args... attrs) {
    for (const auto& attr : {attrs...}) {
      add_attribute(attr);
    }
    return *this;
  }

 protected:
  /* ********************************* */
  /*     CONSTRUCTORS & DESTRUCTORS    */
  /* ********************************* */

  Schema() {}
  
  explicit Schema(const std::shared_ptr<tiledb::Context>& ctx)
      : ctx_(ctx) {
  }
  Schema(const tiledb::Schema&) = default;
  Schema(tiledb::Schema&&) = default;
  tiledb::Schema& operator=(const tiledb::Schema&) = default;
  tiledb::Schema& operator=(tiledb::Schema&&) = default;
  virtual ~Schema() = default;

  /* ********************************* */
  /*          VIRTUAL INTERFACE        */
  /* ********************************* */

  /** Dumps the array schema in an ASCII representation to an output. */
  virtual void dump(const std::string& filename) const = 0; //virtual void dump(FILE* out) const = 0;

  /** Adds an attribute to the array. */
  virtual tiledb::Schema& add_attribute(const tiledb::Attribute& attr) = 0;

  /** Validates the schema. */
  virtual void check() const = 0;

  /** Gets all attributes in the array. */
  //virtual std::map<std::string,tiledb::Attribute> attributes() const = 0; //virtual std::unordered_map<std::string, tiledb::Attribute> attributes() const = 0;

  /** Gets all attribute names in the array */
  virtual std::vector<std::string> attribute_names() const = 0;
  
  /** Number of attributes **/
  virtual unsigned attribute_num() const = 0;

  /** Get an attribute by name. **/
  virtual tiledb::Attribute attribute(const std::string& name) const = 0;

  /** Get an attribute by index **/
  virtual tiledb::Attribute attribute(unsigned int i) const = 0;

  /** The TileDB context. */
  std::shared_ptr<Context> ctx_;

  /** Deleter wrapper. */
  impl::Deleter deleter_;
};

}  // namespace tiledb

#endif  // TILEDB_CPP_API_SCHEMA_BASE_H
